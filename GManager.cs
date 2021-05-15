using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    public static GManager instance;
    public List<GameObject> enemies;
    public int stage;
    private Menu menuSc;
    private BoardManager boardManagerSc;
    public bool isSetting;
    public Transform startPos;
    public Transform clearPos;
    public  Text enemyCountText;
    private AudioSource audioSource;
    public bool isClear;
    public bool isRetry;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        instance.InitGame();
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void InitGame()
    {
        isSetting = true;
        enemies.Clear();
        isClear = false;
        isRetry = false;
        Tankhealth.isInvincible = false;
        startPos = GameObject.Find("StartPos").transform;
        menuSc = GameObject.Find("Ultimate UI Canvas").GetComponent<Menu>();
        enemyCountText = GameObject.FindGameObjectWithTag("EnemyCountText").GetComponent<Text>();
        audioSource = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        audioSource.volume = OptionManager.volume;
        if (StageSelectButton.practiceMode)
        {
            instance.stage = StageSelectButton.stage;
        }
      
      
        instance.stage += 1;
       
        if (Title.isContinuation)
        {
            Title.isContinuation = false;
            instance.stage = PlayerPrefs.GetInt("currentStage");
            Debug.Log("Continue" + instance.stage);
        }
        if (!StageSelectButton.practiceMode && instance.stage != 0)
        {
            PlayerPrefs.SetInt("currentStage", instance.stage);
            Debug.Log(instance.stage);
        }
        if (PlayerPrefs.GetInt("maxStage") <instance.stage)
        {     
            PlayerPrefs.SetInt("maxStage",instance.stage);
        }
        boardManagerSc = GetComponent<BoardManager>();
        clearPos = GameObject.FindGameObjectWithTag("ClearPos").transform;
        boardManagerSc.SetUpScene();
        StartCoroutine(StartImage());
    }

    IEnumerator StartImage()
    {
        menuSc.startImageObj.SetActive(true);
        menuSc.startStageText.text = "Stage" + instance.stage;
        menuSc.startEnemyCountText.text = instance.enemies.Count.ToString();
        yield return new WaitForSeconds(2);
        menuSc.startImageObj.SetActive(false);
        instance.enemyCountText.text = instance.enemies.Count.ToString();
        isSetting = false;
    }


    public void GameOver()
    {
        if (menuSc.gameOverImage != null)
        {
           menuSc.gameOverImage.SetActive(true);
        }
    }

   




}
