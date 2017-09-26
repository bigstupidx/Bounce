using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour {

    public LevelController level;
    public Rigidbody2D player;
    public bool water1;
    public bool water2;

    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<LevelController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (level.player.bold)
            {
                level.player.GetComponent<Rigidbody2D>().velocity = new Vector2(level.player.player.velocity.x, 2f);
            }
        }
    }

}
