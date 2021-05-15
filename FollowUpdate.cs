using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class FollowUpdate :Action
{

   
    public SharedFloat speed = 10;
   
    public SharedFloat angularSpeed = 120;
  
    public SharedFloat arriveDistance = 0.2f;
   
    public SharedBool stopOnTaskEnd = true;
   
    public SharedBool updateRotation = true;

    // Component references
    private NavMeshAgent navMeshAgent;
    private bool startUpdateRotation;
    public GameObject target;
 
    public SharedFloat moveDistance = 2;

    private Vector3 lastTargetPosition;
    private bool hasMoved;

    public override void OnAwake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    public override void OnStart()
    {
        base.OnStart();
        navMeshAgent.speed = speed.Value;
        navMeshAgent.angularSpeed = angularSpeed.Value;
        navMeshAgent.isStopped = false;
        startUpdateRotation = navMeshAgent.updateRotation;
        UpdateRotation(updateRotation.Value);
        target = GameObject.FindGameObjectWithTag("Player");

        lastTargetPosition = target.transform.position + Vector3.one * (moveDistance.Value + 1);
        hasMoved = false;
    }

    private bool SetDestination(Vector3 destination)
    {
        navMeshAgent.isStopped = false;
        return navMeshAgent.SetDestination(destination);
    }

    private void UpdateRotation(bool update)
    {
        navMeshAgent.updateRotation = update;
        navMeshAgent.updateUpAxis = update;
    }

    private bool HasPath()
    {
        return navMeshAgent.hasPath && navMeshAgent.remainingDistance > arriveDistance.Value;
    }

    private Vector3 Velocity()
    {
        return navMeshAgent.velocity;
    }

    private bool SamplePosition(Vector3 position)
    {
        NavMeshHit hit;
        return NavMesh.SamplePosition(position, out hit, navMeshAgent.height * 2, NavMesh.AllAreas);
    }

    private bool HasArrived()
    {
        // The path hasn't been computed yet if the path is pending.
        float remainingDistance;
        if (navMeshAgent.pathPending)
        {
            remainingDistance = float.PositiveInfinity;
        }
        else
        {
            remainingDistance = navMeshAgent.remainingDistance;
        }

        return remainingDistance <= arriveDistance.Value;
    }

    /// <summary>
    /// Stop pathfinding.
    /// </summary>
    private void Stop()
    {
        UpdateRotation(startUpdateRotation);
        if (navMeshAgent.hasPath)
        {
            navMeshAgent.isStopped = true;
        }
    }

    /// <summary>
    /// The task has ended. Stop moving.
    /// </summary>
    public override void OnEnd()
    {
        if (stopOnTaskEnd.Value)
        {
            Stop();
        }
        else
        {
            UpdateRotation(startUpdateRotation);
        }
    }

    /// <summary>
    /// The behavior tree has ended. Stop moving.
    /// </summary>
    public override void OnBehaviorComplete()
    {
        Stop();
    }

    // Follow the target. The task will never return success as the agent should continue to follow the target even after arriving at the destination.
    public override TaskStatus OnUpdate()
    {
        if (target == null)
        {
            return TaskStatus.Failure;
        }

        // Move if the target has moved more than the moveDistance since the last time the agent moved.
        var targetPosition = target.transform.position;
        if ((targetPosition - lastTargetPosition).magnitude >= moveDistance.Value)
        {
            SetDestination(targetPosition);
            lastTargetPosition = targetPosition;
            hasMoved = true;
        }
        else
        {
            // Stop moving if the agent is within the moveDistance of the target.
            if (hasMoved && (targetPosition - transform.position).magnitude < moveDistance.Value)
            {
                Stop();
                hasMoved = false;
                lastTargetPosition = targetPosition;
            }
        }
        return TaskStatus.Running;
    }

    public override void OnReset()
    {
        //   base.OnReset();
        speed = 10;
        angularSpeed = 120;
        arriveDistance = 1;
        stopOnTaskEnd = true;
        target = null;
        moveDistance = 2;
    }
}

