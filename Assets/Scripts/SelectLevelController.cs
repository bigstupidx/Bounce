using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectLevelController : MonoBehaviour, IPointerDownHandler
{
    public GameObject highScore;
    public GameObject buttonLv;
    //public Transform target;
    //public Vector3 current;
    //public Vector3 t;
    public AdsController ads;
    public BannerAds bannerAds;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Level1")
        {
            SceneManager.LoadScene("Lv1");
        }
        if (gameObject.name == "Level2")
        {
            SceneManager.LoadScene("Lv2");
        }
        if (gameObject.name == "Level3")
        {
            SceneManager.LoadScene("Lv3");
        }
        if (gameObject.name == "Level4")
        {
            SceneManager.LoadScene("Lv4");
        }
        if (gameObject.name == "Level5")
        {
            SceneManager.LoadScene("Lv5");
        }
        if (gameObject.name == "Level6")
        {
            SceneManager.LoadScene("Lv6");
        }
        if (gameObject.name == "Level7")
        {
            SceneManager.LoadScene("Lv7");
        }
        if (gameObject.name == "Level8")
        {
            SceneManager.LoadScene("Lv8");
        }
        if (gameObject.name == "Level9")
        {
            SceneManager.LoadScene("Lv9");
        }
        if (gameObject.name == "Level10")
        {
            SceneManager.LoadScene("Lv10");
        }
        if (gameObject.name == "Level11")
        {
            SceneManager.LoadScene("Lv11");
        }
        if (gameObject.name == "Button Back")
        {
            SceneManager.LoadScene("Start");
        }
        if (gameObject.name == "Button Restore")
        {

        }
        if (gameObject.name == "Button Unlock")
        {

        }
        //Select LeaderBoard
        /*
        if (gameObject.name == "LBLevel1")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 1";
            Vector3 temp = new Vector3(16, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel2")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 2";
            Vector3 temp = new Vector3(16 * 2, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel3")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 3";
            Vector3 temp = new Vector3(16 * 3, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel4")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 4";
            Vector3 temp = new Vector3(16 * 4, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel5")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 5";
            Vector3 temp = new Vector3(16 * 5, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel6")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 6";
            Vector3 temp = new Vector3(16 * 6, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel7")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 7";
            Vector3 temp = new Vector3(16 * 7, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel8")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 8";
            Vector3 temp = new Vector3(16 * 8, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel9")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 9";
            Vector3 temp = new Vector3(16 * 9, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel10")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 10";
            Vector3 temp = new Vector3(16 * 10, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "LBLevel11")
        {
            buttonLv.SetActive(false);
            highScore.SetActive(true);
            highScore.gameObject.GetComponentInChildren<Text>().text = "LEVEL 11";
            Vector3 temp = new Vector3(16 * 11, 0, 0);
            target.position += temp;
        }
        if (gameObject.name == "Button Back Level")
        {
            buttonLv.SetActive(true);
            highScore.SetActive(false);
            t = target.position - current;
            target.position -= t;
        }
        */
    }

    // Use this for initialization
    void Start()
    {
        //highScore.gameObject.GetComponentInChildren<Text>().text = "";
        //current = target.position;
    }

    // Update is called once per frame
    void Update()
    {

    }



}
