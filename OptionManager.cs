using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Toggle leftToggle;
    [SerializeField] Toggle rightToggle;
    [SerializeField] Toggle joysticToggle;
    [SerializeField] Toggle buttonToggle;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sound;
    public static float volume;
    public static bool isLeft;
    public static bool isRight;
    public static bool isJoystic;
    public static bool isButton;
    private void Start()
    {
        isLeft = true;
        isRight = false;
        isButton = true;
        isJoystic = false;
        volume = slider.value;
        audioSource.volume = volume;

    }
    public void VolumeChange()
    {
        volume = slider.value;
        audioSource.volume = volume;
    }

    public void ClickLeft()
    {
        SoundManager.instance.PlaySingle(sound);
        isLeft = leftToggle.isOn;
        if (isLeft)
        {
            isRight = false;
            rightToggle.isOn = false;
        }
    }

    public void ClickRight()
    {
        SoundManager.instance.PlaySingle(sound);
        isRight = rightToggle.isOn;
        if (isRight)
        {
            isLeft = false;
            leftToggle.isOn = false;
        }
    }

    public void ClickJoystic()
    {
        SoundManager.instance.PlaySingle(sound);
        isJoystic = joysticToggle.isOn;
        if (isJoystic)
        {
            isButton = false;
            buttonToggle.isOn = false;
        }
    }

    public void ClickButton()
    {
        SoundManager.instance.PlaySingle(sound);
        isButton = buttonToggle.isOn;
        if (isButton)
        {
            isJoystic = false;
            joysticToggle.isOn = false;
        }
    }
}
