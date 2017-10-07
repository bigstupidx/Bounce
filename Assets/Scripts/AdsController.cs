using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AdsController : MonoBehaviour
{
    public InterstitialAd interstitial;

    // Use this for initialization
    void Start()
    {
        RequestInterstitial();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-4291038556071828/8085808598";
#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

    public void ShowInterstitialAD()
    {
        if (interstitial != null && interstitial.IsLoaded())
        {
            interstitial.Show();
        }

    }
}
