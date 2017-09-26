using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsController : MonoBehaviour
{
    public BannerView bannerView;
    public InterstitialAd interstitial;

    // Use this for initialization
    void Start()
    {
        RequestBanner();
        RequestInterstitial();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RequestBanner()
    {
#if UNITY_EDITOR
        string adUnitId = "ca-app-pub-4291038556071828/6609075398";
#elif UNITY_ANDROID
        string adUnitId = "ca-app-pub-4291038556071828/6609075398";
#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
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

    public void showBannerAD()
    {
        if (bannerView != null)
        {
            bannerView.Show();
        }
        Debug.Log("show Banner");
    }

    public void hideBannerAD()
    {
        if(bannerView != null)
        {
            bannerView.Hide();
        }
        Debug.Log("hide Banner");
    }

    void OnDestroy()
    {
        bannerView.Destroy();
    }


}
