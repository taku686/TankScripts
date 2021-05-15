using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject gameOverImage;
    public GameObject clearImage;
    public GameObject completeImage;
    [SerializeField] public GameObject startImageObj;
    [SerializeField] public Text startStageText;
    [SerializeField] public Text startEnemyCountText;
    [SerializeField] GameObject clearSpot;
    [SerializeField] GameObject shotButton;
    [SerializeField] AudioClip decisionSound;
    [SerializeField] GameObject optionImage;
    private TankMovement tankMovementSc;
    private bool isFirst;
    private bool isOpen;

    private void Start()
    {
        if (!OptionManager.isButton)
        {
            shotButton.SetActive(false);
        }
        tankMovementSc = GameObject.FindGameObjectWithTag("Player").GetComponent<TankMovement>();
    }
    private void Update()
    {
        if (GManager.instance.enemies.Count == 0 && !Tankhealth.isInvincible)
        {
            Instantiate(clearSpot, GManager.instance.clearPos.position, Quaternion.identity);
            Tankhealth.isInvincible = true;
        }
    }

    public void Restart()
    {
        GManager.instance.isRetry = true;
       SaveSystem.Instance.UserData.heartCount = 5;
        GManager.instance.stage -= 1;
        SaveSystem.Instance.Save();
    }

    public void NextStage()
    {
        if (StageSelectButton.practiceMode) return;
        SceneManager.LoadScene(1);
    }
    public void Shot()
    {
        tankMovementSc.Shot();
    }

    public void Mine()
    {
        tankMovementSc.Mine();
    }

    public void GiveUpButton()
    {
        gameOverImage.SetActive(false);
        if (!StageSelectButton.practiceMode)
        {
            SaveSystem.Instance.UserData.heartCount = 5;
            SaveSystem.Instance.UserData.shotMaxCount = 10;
            SaveSystem.Instance.UserData.mineMaxCount = 3;
            SaveSystem.Instance.UserData.isDiffuse = false;
            SaveSystem.Instance.UserData.isPenetration = false;
            SaveSystem.Instance.UserData.isBounce = false;
            SaveSystem.Instance.UserData.isNormal = true;
            SaveSystem.Instance.UserData.isLaser = false;
            SaveSystem.Instance.UserData.isReinLaser = false;
            SaveSystem.Instance.Save();
        }
        StageSelectButton.practiceMode = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        if (!isFirst)
        {
            isFirst = true;
            SoundManager.instance.PlaySingle(decisionSound);
            Time.timeScale = 0;
        }
        else
        {
            isFirst = false;
            SoundManager.instance.PlaySingle(decisionSound);
            Time.timeScale = 1;
        }
    }

    public void Setting()
    {
        if (!isOpen)
        {
            isOpen = true;
            SoundManager.instance.PlaySingle(decisionSound);
            Time.timeScale = 0;
            optionImage.SetActive(true);
        }
        else
        {
            isOpen = false;
            SoundManager.instance.PlaySingle(decisionSound);
            Time.timeScale = 1;
            optionImage.SetActive(false);
        }
    }
}
