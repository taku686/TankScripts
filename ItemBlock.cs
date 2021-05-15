using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : DestroyObject
{
    [SerializeField] protected GameObject shellPrefab;
    [SerializeField] protected GameObject minePrefab;
    [SerializeField] protected GameObject heartPrefab;
    [SerializeField] protected GameObject laserPrefab;
    [SerializeField] protected GameObject diffusionPrefab;
    [SerializeField] protected GameObject penetrationPrefab;
    [SerializeField] protected GameObject bouncePrefab;
    [SerializeField] protected GameObject speedUpPrefab;
    [SerializeField] protected GameObject reinLaserPrefab;

    protected override void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Shell") || collision.collider.CompareTag("EnemyShell"))
        {
            Instantiate(effectPrefab, transform.position, Quaternion.identity);
            if (30 > Random.Range(0, 100))
            {
                if (shellPrefab != null)
                {
                    Instantiate(shellPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (minePrefab != null)
                {
                    Instantiate(minePrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (heartPrefab != null)
                {
                    Instantiate(heartPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (laserPrefab != null)
                {
                    Instantiate(laserPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if(diffusionPrefab!= null)
                {
                    Instantiate(diffusionPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (penetrationPrefab != null)
                {
                    Instantiate(penetrationPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (bouncePrefab != null)
                {
                    Instantiate(bouncePrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (speedUpPrefab != null)
                {
                    Instantiate(speedUpPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (reinLaserPrefab != null)
                {
                    Instantiate(reinLaserPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
            }          
            collision.collider.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ExplosionEffect") || other.CompareTag("DiffuseShell") || other.CompareTag("PenetrationShell"))
        {
            Instantiate(effectPrefab, transform.position, Quaternion.identity);
            if (30 > Random.Range(0, 100))
            {
                if (shellPrefab != null)
                {
                    Instantiate(shellPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (minePrefab != null)
                {
                    Instantiate(minePrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (heartPrefab != null)
                {
                    Instantiate(heartPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (laserPrefab != null)
                {
                    Instantiate(laserPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (diffusionPrefab != null)
                {
                    Instantiate(diffusionPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (penetrationPrefab != null)
                {
                    Instantiate(penetrationPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (bouncePrefab != null)
                {
                    Instantiate(bouncePrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (speedUpPrefab != null)
                {
                    Instantiate(speedUpPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
                if (reinLaserPrefab != null)
                {
                    Instantiate(reinLaserPrefab, transform.position, Quaternion.Euler(0, 0, 0));
                }
            }
            Destroy(gameObject);
        }
    }

}
