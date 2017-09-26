using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerSpeedController : MonoBehaviour {

    LevelController level;

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
            level.player.speed = 600;
            StartCoroutine(WaitForIt(15F));
        }

    }

    IEnumerator WaitForIt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        level.player.speed = 300;
    }


}
