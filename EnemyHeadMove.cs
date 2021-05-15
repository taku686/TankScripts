using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyHeadMove : MonoBehaviour
{
    Vector3 target;
    Transform player;
    [SerializeField] EnemyShotShell enemyShotShellSc;
    [SerializeField] LayerMask blockingLayer;
    [SerializeField] bool isAI;
    [SerializeField] bool isBreaker;
    private float limitedAngle = 150;
    private RaycastHit hit;
    public bool isRange;  
    float shellDistance;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (isAI)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.LookAt(player.position);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (isAI)
        {
            if (other.CompareTag("Shell") || other.CompareTag("PenetrationShell") || other.CompareTag("DiffuseShell"))
            {
                if (Vector3.Distance(transform.position, other.transform.position) < 8)
                {
                    float angle = Vector3.Angle(transform.forward, other.transform.position);
                    shellDistance = Vector3.Distance(transform.position, other.transform.position);
                //    Debug.Log(angle);
                    if (shellDistance < 4 && angle <= limitedAngle)
                    {
                        target = new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);
                        if (!enemyShotShellSc.isShooting)
                        {
                            isRange = true;
                            enemyShotShellSc.isShot = true;
                        }
                    }
                }
            }
            else if (other.CompareTag("Player"))
            {
                target = new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);
                isRange = false;
               
                if (Physics.Raycast(transform.position, transform.forward, out hit, 1000, blockingLayer))
                {
                    
                    if (hit.transform.CompareTag("Player"))
                    {                  
                        enemyShotShellSc.isShot = true;
                    }
                    else if (isBreaker && hit.transform.CompareTag("DestroyWall"))
                    {
                               enemyShotShellSc.isShot = true;                       
                    }
                }
            }
        }
        else
        {
            if (other.CompareTag("Player"))
            {
                if (Physics.Raycast(transform.position, transform.forward, out hit, 1000, blockingLayer))
                {
                    if (hit.transform.CompareTag("Player"))
                    {
                        enemyShotShellSc.isShot = true;
                    }
                }
            }
        }
    }
}
