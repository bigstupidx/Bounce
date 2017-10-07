using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour {

    public Sprite checkpointCatched;
    public bool catched;
    public AudioClip audioCheckpoint;
    public AudioSource source;

    public LevelController level;

    // Use this for initialization
    void Start()
    {
        catched = false;
        level = FindObjectOfType<LevelController>();
        source = level.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            level.currentCheckPoint = other.transform.position;
            level.currentSprite = level.player.GetComponent<SpriteRenderer>().sprite;
            level.currentRadius = level.player.GetComponent<CircleCollider2D>().radius;
            level.player.currentGravity = level.player.GetComponent<Rigidbody2D>().gravityScale;
            GetComponent<SpriteRenderer>().sprite = checkpointCatched;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(!catched)
            {
                level.score += 500;
                if(level.sound)
                {
                    source.clip = audioCheckpoint;
                    source.Play();
                }
            }
            catched = true;
        }
    }
}
