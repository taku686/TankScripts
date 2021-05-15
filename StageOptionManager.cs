using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageOptionManager : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Toggle joysticToggle;
    [SerializeField] Toggle buttonToggle;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sound;
    [SerializeField] GameObject shotButton;
    public static float volume;
    private void Start()
    {
        audioSource.volume = volume;

    }
    public void VolumeChange()
    {
        volume = slider.value;
        audioSource.volume = volume;
    }

    public void ClickJoystic()
    {
        SoundManager.instance.PlaySingle(sound);
        OptionManager.isJoystic = joysticToggle.isOn;
        shotButton.SetActive(true);
        if (OptionManager.isJoystic)
        {
            OptionManager.isButton = false;
            buttonToggle.isOn = false;
        }
    }

    public void ClickButton()
    {
        SoundManager.instance.PlaySingle(sound);
        OptionManager.isButton = buttonToggle.isOn;
        shotButton.SetActive(false);
        if (OptionManager.isButton)
        {
            OptionManager.isJoystic = false;
            joysticToggle.isOn = false;
        }
    }
}
