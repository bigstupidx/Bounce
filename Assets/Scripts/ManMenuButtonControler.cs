using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ManMenuButtonControler : MonoBehaviour, IPointerDownHandler
{

    public GameObject yesNo;
    public GameObject blur;

    public AdsController ads;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Button Play")
        {
            SceneManager.LoadScene("ChooseLevelScene");
            PlayerPrefs.SetInt("sound", 1);
        }
        if (gameObject.name == "Button Leaderboard")
        {
            SceneManager.LoadScene("LeaderBoard");
        }
        if (gameObject.name == "Button Rate")
        {
            #if UNITY_ANDROID
                Application.OpenURL("https://play.google.com/store?hl=vi");
            #elif UNITY_IPHONE
                Application.OpenURL("itms-apps://itunes.apple.com/app/idYOUR_ID");
            #endif
        }
        if (gameObject.name == "Button Back")
        {
            SceneManager.LoadScene("Start");
        }
        if(gameObject.name == "Button Restore")
        {
            yesNo.gameObject.SetActive(true);
            blur.gameObject.SetActive(true);
            
        }
        if(gameObject.name == "Button Restore Yes")
        {
            for (int i = 1; i < 12; i++)
            {
                PlayerPrefs.SetInt(i.ToString(), 0);
            }
            SceneManager.LoadScene("ChooseLevelScene");
        }
        if(gameObject.name == "Button No")
        {
            yesNo.gameObject.SetActive(false);
            blur.gameObject.SetActive(false);
        }
        if(gameObject.name == "Button Yes")
        {
            Application.Quit();
        }
    }



    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
#if UNITY_EDITOR
    if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
#elif UNITY_ANDROID
    if (Input.GetKeyDown(KeyCode.Escape)) 
    {
        Application.Quit();
    }
#endif
    }

}
