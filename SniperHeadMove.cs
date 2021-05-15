using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperHeadMove : MonoBehaviour
{
    Transform target;
    bool isColliderHit;
    [SerializeField] SniperRader sniperRaderSc;
    [SerializeField] float turnSpeed;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (isColliderHit || sniperRaderSc.isDirectlyHit)
        {
            transform.LookAt(target);
        }
        HeadMove();    
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isColliderHit = true;        
        }
    }

    private void HeadMove()
    {
        transform.Rotate(new Vector3(0, turnSpeed, 0));
        
    }
}


