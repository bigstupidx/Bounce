using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelCompleteButtonController : MonoBehaviour, IPointerDownHandler
{
    LevelController level;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(gameObject.name == "Button Select Level")
        {
            SceneManager.LoadScene("ChooseLevelScene");
        }
        else if ( gameObject.name == "Button Replay")
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
        else if(gameObject.name == "Button Next Level")
        {
            int currentlevel = level.currentLevel;
            switch (currentlevel)
            {
                case 1:
                    SceneManager.LoadScene("lv2");
                    break;
                case 2:
                    SceneManager.LoadScene("lv3");
                    break;
                case 3:
                    SceneManager.LoadScene("lv4");
                    break;
                case 4:
                    SceneManager.LoadScene("lv5");
                    break;
                case 5:
                    SceneManager.LoadScene("lv6");
                    break;
                case 6:
                    SceneManager.LoadScene("lv7");
                    break;
                case 7:
                    SceneManager.LoadScene("lv8");
                    break;
                case 8:
                    SceneManager.LoadScene("lv9");
                    break;
                case 9:
                    SceneManager.LoadScene("lv10");
                    break;
                case 10:
                    SceneManager.LoadScene("lv11");
                    break;
                case 11:
                    SceneManager.LoadScene("ChooseLevelScene");
                    break;
            }
        }
    }

    // Use this for initialization
    void Start () {
        level = FindObjectOfType<LevelController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
