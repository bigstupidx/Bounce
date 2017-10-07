using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BannerAds : MonoBehaviour {

    public BannerView bannerView;

    // Use this for initialization
    void Start () {
        RequestBanner();
        bannerView.Show();
    }

    // Update is called once per frame
    void Update () {
		
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

    public void showBannerAD()
    {
        if (bannerView != null)
        {
            bannerView.Show();
        }
    }

    public void hideBannerAD()
    {
        if(bannerView != null)
        {
            bannerView.Hide();
        }
    }

    private void OnDestroy()
    {
        bannerView.Destroy();
    }

}
