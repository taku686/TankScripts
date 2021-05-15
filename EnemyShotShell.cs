using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour
{
    public float shotSpeed;
    [SerializeField] private float shotRate;
    [SerializeField] private int shotInterval;
    [SerializeField] private Transform shotPos;
    [SerializeField] private Transform shotPos1;
    [SerializeField] Transform headTransform;
    [SerializeField] int MaxShotCount;
    [SerializeField] EnemyHeadMove enemyHeadMove;
    [SerializeField] int bounce;
    private int shotCount;
    private ShellManager shellManagerSc;
    public AudioClip shotSound;
    
    public bool isShot;
    public bool isShooting;

    private void Start()
    {
        shellManagerSc = GameObject.FindGameObjectWithTag("ShellManager").GetComponent<ShellManager>();
    }

    private void Update()
    {
        if (isShot  && !Tankhealth.isInvincible && !GManager.instance.isSetting&&!isShooting)
        {
            StartCoroutine(Shot());
        }
    }

    IEnumerator Shot()
    {
        if (shotCount < MaxShotCount)
        {
            shotCount += 1;
            isShot = false;
            isShooting = true;
            GameObject enemyShell = shellManagerSc.GetEnemyShell();
            enemyShell.GetComponent<EnemyShell>().bounceCount = bounce;
            enemyShell.transform.position = shotPos.position;
            enemyShell.transform.rotation = Quaternion.Euler(0, headTransform.rotation.eulerAngles.y + 90, 90);
            Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();
            enemyShellRb.AddForce(transform.forward * shotSpeed);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
            if (shotPos1 != null)
            {
                StartCoroutine(DoubleShot());
            }
            if (enemyHeadMove.isRange)
            {
                yield return new WaitForSeconds(0.1f);
            }
            else if (!enemyHeadMove.isRange)
            {
                yield return new WaitForSeconds(shotRate);
            }
          
            isShooting = false;
        }
        else
        {
            yield return new WaitForSeconds(shotInterval);
            shotCount = 0;
        }
        
    }



    IEnumerator DoubleShot()
    {
        yield return new WaitForSeconds(0.1f);
        GameObject enemyShell1 = shellManagerSc.GetEnemyShell();
        enemyShell1.transform.position = shotPos1.position;
        enemyShell1.transform.rotation = Quaternion.Euler(0, headTransform.rotation.eulerAngles.y + 90, 90);
        Rigidbody enemyShellRb1 = enemyShell1.GetComponent<Rigidbody>();
        enemyShellRb1.AddForce(transform.forward * shotSpeed);
        AudioSource.PlayClipAtPoint(shotSound, transform.position);
    }
}
