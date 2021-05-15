using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime.Tasks.Movement;

public class WithinDistanceUpdate : Conditional
{

    public bool usePhysics2D;

    public SharedGameObject targetObject;

    public SharedString targetTag;

    public LayerMask objectLayerMask;

    public SharedFloat magnitude = 5;

    public SharedBool lineOfSight;

    public LayerMask ignoreLayerMask = 1 << LayerMask.NameToLayer("Ignore Raycast");

    public SharedVector3 offset;

    public SharedVector3 targetOffset;

    public SharedBool drawDebugRay;

    public SharedGameObject returnedObject;

    private List<GameObject> objects;
    // distance * distance, optimization so we don't have to take the square root
    private float sqrMagnitude;
    private bool overlapCast = false;

    public override void OnStart()
    {
        sqrMagnitude = magnitude.Value * magnitude.Value;

        if (objects != null)
        {
            objects.Clear();
        }
        else
        {
            objects = new List<GameObject>();
        }
        // if objects is null then find all of the objects using the layer mask or tag
        if (targetObject.Value == null)
        {
            if (!string.IsNullOrEmpty(targetTag.Value))
            {
                /*
                var gameObjects = GameObject.FindGameObjectsWithTag(targetTag.Value);
                for (int i = 0; i < gameObjects.Length; ++i)
                {
                    objects.Add(gameObjects[i]);
                }
                */
                overlapCast = true;
            }
            else
            {
                overlapCast = true;
            }
        }
        else
        {
            objects.Add(targetObject.Value);
        }
    }

    // returns success if any object is within distance of the current object. Otherwise it will return failure
    public override TaskStatus OnUpdate()
    {
        if (transform == null || objects == null)
            return TaskStatus.Failure;

        if (overlapCast)
        {
            objects.Clear();
            if (usePhysics2D)
            {
                var colliders = Physics2D.OverlapCircleAll(transform.position, magnitude.Value, objectLayerMask.value);
                for (int i = 0; i < colliders.Length; ++i)
                {
                    objects.Add(colliders[i].gameObject);
                }
            }
            else
            {
                var colliders = Physics.OverlapSphere(transform.position, magnitude.Value, objectLayerMask.value);
                for (int i = 0; i < colliders.Length; ++i)
                {
                    if (colliders[i].gameObject.CompareTag(targetTag.Value))
                    {
                        objects.Add(colliders[i].gameObject);
                    }
                   
                }
            }
        }

        Vector3 direction;
        // check each object. All it takes is one object to be able to return success
        for (int i = 0; i < objects.Count; ++i)
        {
            if (objects[i] == null)
            {
                continue;
            }
            direction = objects[i].transform.position - (transform.position + offset.Value);
            // check to see if the square magnitude is less than what is specified
            if (Vector3.SqrMagnitude(direction) < sqrMagnitude)
            {
                // the magnitude is less. If lineOfSight is true do one more check
                if (lineOfSight.Value)
                {
                    var hitTransform = MovementUtility.LineOfSight(transform, offset.Value, objects[i], targetOffset.Value, usePhysics2D, ignoreLayerMask.value, drawDebugRay.Value);
                    if (hitTransform != null)
                    {
                        // the object has a magnitude less than the specified magnitude and is within sight. Set the object and return success
                        returnedObject.Value = objects[i];
                        return TaskStatus.Success;
                    }
                }
                else
                {
                    // the object has a magnitude less than the specified magnitude. Set the object and return success
                    returnedObject.Value = objects[i];
                    return TaskStatus.Success;
                }
            }
        }
        // no objects are within distance. Return failure
        return TaskStatus.Failure;
    }

    public override void OnReset()
    {
        usePhysics2D = false;
        targetObject = null;
        targetTag = string.Empty;
        objectLayerMask = 0;
        magnitude = 5;
        lineOfSight = true;
        ignoreLayerMask = 1 << LayerMask.NameToLayer("Ignore Raycast");
        offset = Vector3.zero;
        targetOffset = Vector3.zero;
    }

    // Draw the seeing radius
    public override void OnDrawGizmos()
    {
#if UNITY_EDITOR
        if (Owner == null || magnitude == null)
        {
            return;
        }
        var oldColor = UnityEditor.Handles.color;
        UnityEditor.Handles.color = Color.yellow;
        UnityEditor.Handles.DrawWireDisc(Owner.transform.position, usePhysics2D ? Owner.transform.forward : Owner.transform.up, magnitude.Value);
        UnityEditor.Handles.color = oldColor;
#endif
    }
}

