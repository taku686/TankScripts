using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffuseShell : MonoBehaviour
{
    [SerializeField] GameObject explosionEffect;
    [SerializeField] AudioClip explosionSound;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy") ||other.CompareTag("Player") || other.CompareTag("Shell") || other.CompareTag("EnemyShell") || other.CompareTag("DestroyWall") || other.CompareTag("Wall")|| other.CompareTag("OutWall"))
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            gameObject.SetActive(false);
        }
    }
}
