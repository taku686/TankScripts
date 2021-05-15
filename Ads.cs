using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
public class Ads : MonoBehaviour,IUnityAdsListener
{
    private bool isAd;
    private void Start()
    {
        isAd = false;
        //アンドロイドに設定してある
        Advertisement.Initialize("4026835");
    }

    private void Update()
    {
        if (GManager.instance.stage % 5 == 0 && GManager.instance.isClear == true && isAd == false && GManager.instance.stage != 100 && !StageSelectButton.practiceMode)
        {
            isAd = true;
            ShowRewardedAd();
        }
        else if (GManager.instance.isRetry && isAd == false)
        {
            isAd = true;
            ShowRewardedAd();
        }
    }
    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsReady(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                if (GManager.instance.isRetry)
                {
                    SceneManager.LoadScene(1);
                }
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }


}
