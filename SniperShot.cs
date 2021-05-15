using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperShot : MonoBehaviour
{
    public GameObject enemyShellPrefab;
    public float shotSpeed;
    [SerializeField] private Transform shotPos;
    [SerializeField] Transform headTransform;
    [SerializeField] SniperRader sniperRaderSc;
    public AudioClip shotSound;
    private bool isShooting;
    [SerializeField] private float waitiingTime;
    private ShellManager shellManagerSc;
    [SerializeField] int bounceNum;

    private void Start()
    {
        shellManagerSc = GameObject.FindGameObjectWithTag("ShellManager").GetComponent<ShellManager>();
    }

    private void Update()
    {
        if ((sniperRaderSc.isDirectlyHit || sniperRaderSc.isIndirectlyHit) && !isShooting && !GManager.instance.isSetting)
        {
            StartCoroutine(Shot());
        }
    }
    IEnumerator Shot()
    {
        if (!Tankhealth.isInvincible)
        {
            isShooting = true;
            GameObject enemyShell = shellManagerSc.GetEnemyShell();
            enemyShell.transform.position = shotPos.position;
            enemyShell.transform.rotation = Quaternion.Euler(0, headTransform.rotation.eulerAngles.y + 90, 90);
            Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();
            enemyShell.GetComponent<EnemyShell>().bounceCount = bounceNum;
            enemyShellRb.AddForce(transform.forward * shotSpeed);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
            yield return new WaitForSeconds(waitiingTime);
            isShooting = false;

        }
    }
}
