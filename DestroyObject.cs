using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] protected GameObject effectPrefab;
 
    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Shell")|| collision.collider.CompareTag("EnemyShell"))
        {
            Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ExplosionEffect") || other.CompareTag("DiffuseShell") || other.CompareTag("PenetrationShell"))
        {
            Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
