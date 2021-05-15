using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectButton : MonoBehaviour
{
    public static bool practiceMode;
    public static int stage;
    [SerializeField] AudioClip sound;
    public void SelectButton()
    {
        for (int i = 0; i < 101; i++)
        {
            if (i.ToString() == GetComponentInChildren<Text>().text)
            {
               stage = i-1;
                practiceMode = true;
                SoundManager.instance.PlaySingle(sound);
                SceneManager.LoadScene(1);
            }
        }
    }
}
