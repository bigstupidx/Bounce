using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumperController : MonoBehaviour {

    public LevelController level;

    public Sprite bigBall;

    // Use this for initialization
    void Start () {
        level = FindObjectOfType<LevelController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            level.player.GetComponent<SpriteRenderer>().sprite = bigBall;
            level.player.GetComponent<CircleCollider2D>().radius = 1.05f;
            level.player.JumpHeight = 20f;
            level.player.bold = true;
        }
    }
}
