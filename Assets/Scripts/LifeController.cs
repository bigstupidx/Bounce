using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour {

    public LevelController level;
    public bool catched;
    public AudioClip lifeCatched;
    public AudioSource lifeCatchedSource;

    public Text numbersOfLife;

    // Use this for initialization
    void Start () {
        catched = false;
        level = FindObjectOfType<LevelController>();
        numbersOfLife = GameObject.FindGameObjectWithTag("noLife").GetComponentInChildren<Text>();
        lifeCatchedSource = level.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            level.player.life++;
            numbersOfLife.text = "x" + level.player.life.ToString();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(!catched)
            {
                level.score += 1000;
                if(level.sound)
                {
                    lifeCatchedSource.clip = lifeCatched;
                    lifeCatchedSource.Play();
                }
            }
            catched = true;
        }
    }
}
