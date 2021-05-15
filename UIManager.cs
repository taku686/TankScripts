using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateJoystickExample;

public class UIManager : MonoBehaviour
{
    [SerializeField] UltimateJoystick moveHandle;
    [SerializeField] UltimateJoystick turnHandle;
    [SerializeField] GameObject buttons;
     // Start is called before the first frame update
    void Start()
    {
        Left();
        Right();
    }

    public void Left()
    {
        if (OptionManager.isLeft)
        {
            moveHandle.anchor = UltimateJoystick.Anchor.Right;
            turnHandle.anchor = UltimateJoystick.Anchor.Left;
            buttons.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        }
    }

    public void Right()
    {
        if (OptionManager.isRight)
        {
            moveHandle.anchor = UltimateJoystick.Anchor.Left;
            turnHandle.anchor = UltimateJoystick.Anchor.Right;
            buttons.GetComponent<RectTransform>().anchoredPosition = new Vector3(1409, 0, 0);
        }
    }
}
