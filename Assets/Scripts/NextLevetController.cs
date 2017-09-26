using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class NextLevetController : MonoBehaviour
{
    StarController starController;
    public LevelController level;
    public Image star1;
    public Image star2;
    public Image star3;
    public Sprite star;
    public Text score;
    public GameObject levelCompleteMenu;
    public bool catched;

    public AudioClip clip;
    public AudioSource source;
    public AdsController ads;

    // Use this for initialization
    void Start()
    {
        catched = false;
        level = FindObjectOfType<LevelController>();
        levelCompleteMenu = GameObject.FindGameObjectWithTag("ShowOnLevelComplete");
        levelCompleteMenu.SetActive(false);
        source = level.GetComponent<AudioSource>();
        ads = FindObjectOfType<AdsController>();
        if(PlayerPrefs.GetInt(level.currentLevel.ToString()) != 1 &&
            PlayerPrefs.GetInt(level.currentLevel.ToString()) != 2 &&
            PlayerPrefs.GetInt(level.currentLevel.ToString()) != 3)
        {
            PlayerPrefs.SetInt(level.currentLevel.ToString(), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && level.numberOfRingTarget == 0)
        {
            level.blur.SetActive(true);
            if (!catched)
            {
                level.score = level.score + ((level.player.life) * 1000);
                catched = true;
                levelCompleteMenu.SetActive(true);
                if (level.sound)
                {
                    source.clip = clip;
                    source.Play();
                }
                ads.ShowInterstitialAD();
            }
            setScore();
            setStar();

        }
    }

    void setStar()
    {
        star1.sprite = star;
        if (level.score >= level.threeStarScore)
        {
            star2.sprite = star;
            star3.sprite = star;
            if (PlayerPrefs.GetInt(level.currentLevel.ToString()) == 1 ||
                PlayerPrefs.GetInt(level.currentLevel.ToString()) == 2 ||
                PlayerPrefs.GetInt(level.currentLevel.ToString()) == 0)
                PlayerPrefs.SetInt(level.currentLevel.ToString(), 3);
        }
        else if (level.score >= level.twoStarScore)
        {
            star2.sprite = star;
            if (PlayerPrefs.GetInt(level.currentLevel.ToString()) == 1 ||
                PlayerPrefs.GetInt(level.currentLevel.ToString()) == 0)
                PlayerPrefs.SetInt(level.currentLevel.ToString(), 2);
        }
        else
        {
            if (PlayerPrefs.GetInt(level.currentLevel.ToString()) == 0)
                PlayerPrefs.SetInt(level.currentLevel.ToString(), 1);
        }

    }

    void setScore()
    {
        score.text = level.score.ToString();
    }


}
