using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShell : MonoBehaviour
{
    [SerializeField] int bounceCount;
    [HideInInspector] public int currentBounceCount;
    [SerializeField] GameObject explosionEffect;
    [SerializeField] AudioClip explosionSound;
    Rigidbody rb;
    private Vector3 lastVelocity;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") || collision.collider.CompareTag("Shell") || collision.collider.CompareTag("EnemyShell") || collision.collider.CompareTag("DestroyWall"))
        {
            Instantiate(explosionEffect, transform.position,Quaternion.identity);
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            gameObject.SetActive(false);
        }
        else if (collision.collider.CompareTag("Wall")|| collision.collider.CompareTag("OutWall"))
        {
            currentBounceCount += 1;
            if (currentBounceCount > bounceCount)
            {
                Instantiate(explosionEffect, transform.position,Quaternion.identity);
                AudioSource.PlayClipAtPoint(explosionSound, transform.position);
                gameObject.SetActive(false);
            }
            Vector3 reflect = Vector3.Reflect(lastVelocity, collision.contacts[0].normal);
            if (reflect.x > 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, Mathf.Acos(reflect.z / reflect.magnitude) / Mathf.PI * 180+90, 90)) ;
                rb.velocity = reflect;
            }
            else if (reflect.x < 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, Mathf.Acos(reflect.z / reflect.magnitude) / Mathf.PI * -180+90, 90));
                rb.velocity = reflect;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            gameObject.SetActive(false);
        }
    }


}
