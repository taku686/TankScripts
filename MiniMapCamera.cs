using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    private Transform playerPos;

    // Update is called once per frame
    private void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        if (playerPos != null)
        {
            MoveMiniMapCamera();
        }
    }

    void MoveMiniMapCamera()
    {
        transform.position = new Vector3(playerPos.position.x,25, playerPos.position.z);
    }
}
