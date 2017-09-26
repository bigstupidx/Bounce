using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerjumpController : MonoBehaviour
{

    LevelController level;
    public float jump;

    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<LevelController>();
        jump = 16f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (level.player.jump)
            {
                if (jump < 30)
                {
                    jump = jump * 1.12f;
                    level.player.JumpHeight = jump;
                }
            }
            else
            {
                level.player.JumpHeight = 16;
                jump = 16;
            }
        }
    }


}
