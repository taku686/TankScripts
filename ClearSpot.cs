using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSpot : MonoBehaviour
{
    private Menu menuSc;
    [SerializeField] AudioClip sound;
    private void Start()
    {
        menuSc = GameObject.Find("Ultimate UI Canvas").GetComponent<Menu>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(GManager.instance.stage == 100)
            {
                menuSc.completeImage.SetActive(true);
                GManager.instance.isClear = true;
                AudioSource.PlayClipAtPoint(sound, transform.position);
            }
            else
            {
                menuSc.clearImage.SetActive(true);
                GManager.instance.isClear = true;
                AudioSource.PlayClipAtPoint(sound, transform.position);
            }
           
        }
    }
}
