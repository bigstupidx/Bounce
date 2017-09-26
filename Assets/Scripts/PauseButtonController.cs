using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseButtonController : MonoBehaviour, IPointerDownHandler
{
    public GameObject blur;
    GameObject pauseObject;
    LevelController level;
    public Sprite soundOn;
    public Sprite soundOff;


    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1.0f;
        level = FindObjectOfType<LevelController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Button Pause")
        {
            blur.SetActive(true);
            Pause();
            level.pauseMenu.SetActive(true);
        }
        if (gameObject.name == "Button Resume")
        {
            blur.SetActive(false);
            Time.timeScale = 1.0f;
            level.pauseMenu.SetActive(false);
            
        }
        if (gameObject.name == "Button Restart")
        {
            int currentlevel = level.currentLevel;
            switch (currentlevel)
            {
                case 1:
                    SceneManager.LoadScene("lv1");
                    break;
                case 2:
                    SceneManager.LoadScene("lv2");
                    break;
                case 3:
                    SceneManager.LoadScene("lv3");
                    break;
                case 4:
                    SceneManager.LoadScene("lv4");
                    break;
                case 5:
                    SceneManager.LoadScene("lv5");
                    break;
                case 6:
                    SceneManager.LoadScene("lv6");
                    break;
                case 7:
                    SceneManager.LoadScene("lv7");
                    break;
                case 8:
                    SceneManager.LoadScene("lv8");
                    break;
                case 9:
                    SceneManager.LoadScene("lv9");
                    break;
                case 10:
                    SceneManager.LoadScene("lv10");
                    break;
                case 11:
                    SceneManager.LoadScene("lv11");
                    break;
            }
        }
        if (gameObject.name == "Button Menu")
        {
            SceneManager.LoadScene("Start");
        }
        if (gameObject.name == "Button Sound")
        {
            if (level.sound)
            {
                gameObject.GetComponent<Image>().sprite = soundOn;
                level.sound = !level.sound; ;
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = soundOff;
                level.sound = !level.sound;
            }
        }
    }

    void Pause()
    {
        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0;
        }
    }
}
