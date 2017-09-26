using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deflaterController : MonoBehaviour {

    public LevelController level;
    public Sprite smallball;


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
            level.player.GetComponent<SpriteRenderer>().sprite = smallball;
            level.player.bold = false;
            level.player.GetComponent<CircleCollider2D>().radius = 0.8f;
            level.player.JumpHeight = 16f;
            
        }
    }
}
