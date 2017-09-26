using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingController : MonoBehaviour {

    public LevelController level;
    public Sprite RingCatched;
    public bool catched;
    public AudioClip ringCatched;
    public AudioSource ringCatchedSound;

    Text numOfRingLeft;

	// Use this for initialization
	void Start () {
        catched = false;
        level = FindObjectOfType<LevelController>();
        numOfRingLeft = GameObject.FindGameObjectWithTag("noRingLeft").GetComponentInChildren<Text>();
        ringCatchedSound = level.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        numOfRingLeft.text = "x" + level.numberOfRingTarget;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            level.numberOfRingTarget -= 0.5f;
            GetComponent<SpriteRenderer>().sprite = RingCatched;
            Destroy(GetComponent<BoxCollider2D>());
            if(!catched)
            {
                level.score += 250;
                if(level.sound)
                {
                    ringCatchedSound.clip = ringCatched;
                    ringCatchedSound.Play();
                } 
            }
            catched = true;
        }
    }

}
