using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRader : MonoBehaviour
{
    [SerializeField] Transform shotPos;
    [SerializeField] Transform head;
    [SerializeField] LayerMask blockingLayer;
    public bool isDirectlyHit;
    public bool isIndirectlyHit;
    public bool isWallHit;
    
    // Update is called once per frame
    void Update()
    {
        Rader();
    }

    private void Rader()
    {
        if (Physics.Raycast(shotPos.position, head.transform.forward, out RaycastHit hit, 1000, blockingLayer))
        {
            if (hit.transform.CompareTag("Player"))
            {
                isDirectlyHit = true;
                return;
            }
            if(hit.normal.z != 0)
            {
                Vector3 reflect = Vector3.Reflect(head.transform.forward, new Vector3(0,0,1));
                if (Physics.Raycast(hit.point, reflect, out RaycastHit hit1, 1000, blockingLayer))
                {
                    if (hit1.transform.CompareTag("Player"))
                    {
                        isIndirectlyHit = true;
                        return;
                    }
                }
            }if(hit.normal.x!= 0)
            {
                Vector3 reflect = Vector3.Reflect(head.transform.forward, new Vector3(1,0,0));
                if (Physics.Raycast(hit.point, reflect, out RaycastHit hit1, 1000, blockingLayer))
                {
                    if (hit1.transform.CompareTag("Player"))
                    {
                        isIndirectlyHit = true;
                        return;
                    }
                }
            }
           
        }
        isDirectlyHit = false;
        isIndirectlyHit = false;
    }
}
