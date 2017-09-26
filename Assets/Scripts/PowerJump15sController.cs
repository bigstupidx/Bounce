using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerJump15sController : MonoBehaviour {

    LevelController level;

	// Use this for initialization
	void Start () {
        level = FindObjectOfType<LevelController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            level.player.JumpHeight = 30;
            StartCoroutine(WaitForIt(15F));
        }
    }

    IEnumerator WaitForIt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        level.player.JumpHeight = 16;
    }
}
