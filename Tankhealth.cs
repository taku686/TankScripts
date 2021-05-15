using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tankhealth : MonoBehaviour
{
    [SerializeField] GameObject explosionEffect;
    [SerializeField] MeshRenderer body;
    [SerializeField] MeshRenderer head;
    [SerializeField] MeshRenderer canon;
    [SerializeField] MeshRenderer b_Left;
    [SerializeField] MeshRenderer b_Right;
    [SerializeField] MeshRenderer f_Left;
    [SerializeField] MeshRenderer f_Right;
    [SerializeField] TankMovement tankMovementSc;
    [SerializeField] AudioClip powerUpSound;
    private Transform startPos;
    private Text heartNumText;
    private GameObject miniMap;
    private GameObject miniMapCamera;
    private Camera mainCamera;
    public static bool isInvincible;

    private void Start()
    {
        miniMap = GameObject.Find("MiniMap");
        miniMapCamera = GameObject.Find("MiniMapCamera");
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        heartNumText = GameObject.Find("HeartCountText").GetComponent<Text>();
        heartNumText.text = SaveSystem.Instance.UserData.heartCount.ToString();
        startPos = GameObject.Find("StartPos").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Shell") || collision.collider.CompareTag("EnemyShell"))
        {
            collision.collider.gameObject.SetActive(false);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);         
            if (SaveSystem.Instance.UserData.heartCount > 0 && !isInvincible)
            {
                StartCoroutine(ReStart());
            }
            else if (SaveSystem.Instance.UserData.heartCount <= 0 && !isInvincible)
            {
                mainCamera.enabled = true;
                miniMap.SetActive(false);
                miniMapCamera.SetActive(false);
                Destroy(gameObject);
                GManager.instance.GameOver();
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HPItem"))
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            SaveSystem.Instance.UserData.heartCount += 1;
            SaveSystem.Instance.Save();
            heartNumText.text = SaveSystem.Instance.UserData.heartCount.ToString();
            
        }
        if ((other.CompareTag("ExplosionEffect") || other.CompareTag("DiffuseShell")) && !isInvincible)
        {
            if (SaveSystem.Instance.UserData.heartCount > 0)
            {
                StartCoroutine(ReStart());
            }
            else
            {
                mainCamera.enabled = true;
                miniMap.SetActive(false);
                miniMapCamera.SetActive(false);
                Destroy(gameObject);
                GManager.instance.GameOver();
            }
        }
    }

    IEnumerator ReStart()
    {
        if (!isInvincible)
        {
            isInvincible = true;
            body.enabled = false;
            head.enabled = false;
            canon.enabled = false;
            b_Left.enabled = false;
            b_Right.enabled = false;
            f_Left.enabled = false;
            f_Right.enabled = false;
            transform.position = startPos.position;
            SaveSystem.Instance.UserData.heartCount -= 1;
            heartNumText.text = SaveSystem.Instance.UserData.heartCount.ToString();
            SaveSystem.Instance.Save();
            yield return new WaitForSeconds(0.3f);
            float time = 0;

            while (time < 3)
            {
                body.enabled = true;
                head.enabled = true;
                canon.enabled = true;
                b_Left.enabled = true;
                b_Right.enabled = true;
                f_Left.enabled = true;
                f_Right.enabled = true;
                yield return new WaitForSeconds(0.5f);
                body.enabled = false;
                head.enabled = false;
                canon.enabled = false;
                b_Left.enabled = false;
                b_Right.enabled = false;
                f_Left.enabled = false;
                f_Right.enabled = false;
                yield return new WaitForSeconds(0.5f);
                time += 1;
            }
            body.enabled = true;
            head.enabled = true;
            canon.enabled = true;
            b_Left.enabled = true;
            b_Right.enabled = true;
            f_Left.enabled = true;
            f_Right.enabled = true;
            isInvincible = false;
        }
    }
}
