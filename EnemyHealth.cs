using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private GameObject effect1;
    private void Awake()
    {
        GManager.instance.enemies.Add(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ExplosionEffect") || other.CompareTag("DiffuseShell") || other.CompareTag("PenetrationShell") || other.CompareTag("Shell"))
        {
            Instantiate(effect1, new Vector3(transform.position.x, 0.6f, transform.position.z), Quaternion.Euler(90, 0, 0));
            GManager.instance.enemies.Remove(gameObject);
            GManager.instance.enemyCountText.text = GManager.instance.enemies.Count.ToString();
            Destroy(gameObject);
        }
    }
}
