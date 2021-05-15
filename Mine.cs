using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Mine : MonoBehaviour
{
    [SerializeField] BoxCollider boxCollider;
    [SerializeField] AudioClip explosionSound;
    [SerializeField] GameObject explosionEffect;
    [SerializeField] GameObject shellEffect;
    [SerializeField] AudioSource audioSource;
    
    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(Explosion());
    }

    IEnumerator Explosion()
    {
        audioSource.Play();
        yield return new WaitForSeconds(5);
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        yield return null;
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell") || other.CompareTag("EnemyShell")|| other.CompareTag("DiffuseShell") || other.CompareTag("PenetrationShell"))
        {
            audioSource.Stop();
            other.gameObject.SetActive(false);
            Instantiate(shellEffect, other.transform.position, Quaternion.identity);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            Destroy(gameObject);
        }
        else if (other.CompareTag("ExplosionEffect"))
        {
            audioSource.Stop();
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            Destroy(gameObject);
        }
    }
}
