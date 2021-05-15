using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Title : MonoBehaviour
{
	[SerializeField] GameObject stageSelectImage;
	[SerializeField] GameObject stageSelectContent;
	[SerializeField] GameObject stageSelectButton;
	[SerializeField] GameObject optionPanelImage;
	[SerializeField] GameObject buttonExplanation;
	[SerializeField] GameObject joysticExplanation;
	[SerializeField] GameObject startSelectImage;
	[SerializeField] AudioClip sound;
	private List<GameObject> buttons = new List<GameObject>();
	public static bool isContinuation;
    private void Start()
    {

		StageSelectButton.practiceMode = false;
		if(GManager.instance != null)
        {
			GManager.instance.stage = 0;
		}		   
	}
	public void PracticeModeButton()
	{
		for(int j = 0; j < buttons.Count; j++)
        {
			Destroy(buttons[j]);			
        }
		buttons.Clear();
		SoundManager.instance.PlaySingle(sound);
		stageSelectImage.SetActive(true);
		if (PlayerPrefs.HasKey("maxStage"))
		{
			for (int i = 1; i < PlayerPrefs.GetInt("maxStage") + 1; i++)
			{
				GameObject selectButtonClone = Instantiate(stageSelectButton, stageSelectContent.transform);
				buttons.Add(selectButtonClone);
				selectButtonClone.GetComponentInChildren<Text>().text = i.ToString();
			}
		}
	}

	public void OptionButton()
    {
		optionPanelImage.SetActive(true);
		SoundManager.instance.PlaySingle(sound);
    }

	public void StartButton()
	{
		SoundManager.instance.PlaySingle(sound);
		startSelectImage.SetActive(true);
	//	SceneManager.LoadScene(1);
	}

	public void BeginningStart()
    {
		SoundManager.instance.PlaySingle(sound);
		SceneManager.LoadScene(1);
	}

	public void ContinuationStart()
	{
		if (PlayerPrefs.HasKey("currentStage") && PlayerPrefs.GetInt("currentStage") != 0)
		{
			isContinuation = true;
			SoundManager.instance.PlaySingle(sound);
			SceneManager.LoadScene(1);
		}
	}

	public void BackButton()
	{
		SoundManager.instance.PlaySingle(sound);
		stageSelectImage.SetActive(false);
		optionPanelImage.SetActive(false);
		startSelectImage.SetActive(false);
	}

	public void EnterButtonExplanation()
    {
		buttonExplanation.SetActive(true);
    }

	public void ExitButtonExplanation()
	{
		buttonExplanation.SetActive(false);
	}

	public void EnterJoysticExplanation()
	{
		joysticExplanation.SetActive(true);
	}
	public void ExitJoysticExplanation()
	{
		joysticExplanation.SetActive(false);
	}
}