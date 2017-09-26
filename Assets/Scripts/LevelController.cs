using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

    public Vector3 currentCheckPoint;
    public PlayerController player;
    public int currentLevel;
    public float numberOfRingTarget;
    public GameObject nextLevelSprite;
    public Sprite currentSprite;
    public float currentRadius;
    public GameObject pauseMenu;
    public GameObject blur;
    public GameObject levelFailMenu;
    public int twoStarScore;
    public int threeStarScore;

    public bool sound;
    public int score;

    public Animator nextLevel;
    Text scr;

    public AdsController ads;
    

    // Use this for initialization
    void Start () {
        score = 0;
        scr = GameObject.FindGameObjectWithTag("Score").GetComponentInChildren<Text>();
        pauseMenu = GameObject.FindGameObjectWithTag("ShowOnPause");
        pauseMenu.SetActive(false);
        blur = GameObject.FindGameObjectWithTag("Blur");
        blur.SetActive(false);
        levelFailMenu = GameObject.FindGameObjectWithTag("ShowOnLevelFail");
        levelFailMenu.SetActive(false);
        player = FindObjectOfType<PlayerController>();
        currentCheckPoint = player.transform.position;
        currentSprite = player.GetComponent<SpriteRenderer>().sprite;
        currentRadius = player.GetComponent<CircleCollider2D>().radius;
        nextLevel = nextLevelSprite.GetComponent<Animator>();
        sound = true;
        ads = FindObjectOfType<AdsController>();
        ads.bannerView.Destroy();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        scr.text = score.ToString();
        IsNextLevel();
        ShowLevelFailMenu();
	}

    void IsNextLevel()
    {
        if (numberOfRingTarget == 0)
        {
            nextLevel.SetBool("isNextLevel", true);
        }
    }

    bool isLevelFail()
    {
        if (player.life == 0)
        {
            return true;
        }
        else return false;
    }

    void ShowLevelFailMenu()
    {
        if(isLevelFail())
        {
            Time.timeScale = 0;
            ads.ShowInterstitialAD();
            levelFailMenu.SetActive(true);
            blur.SetActive(true);
        }
    }
}
