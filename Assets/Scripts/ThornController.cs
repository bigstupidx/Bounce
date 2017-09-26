using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThornController : MonoBehaviour
{

    public LevelController level;

    public Sprite pop;
    public Text numbersOfLife;
    bool die;

    public AudioClip clip;
    public AudioSource source;

    // Use this for initialization
    void Start()
    {
        level = FindObjectOfType<LevelController>();
        numbersOfLife = GameObject.FindGameObjectWithTag("noLife").GetComponentInChildren<Text>();
        die = false;
        source = level.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            level.player.GetComponent<SpriteRenderer>().sprite = pop;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            level.player.GetComponent<SpriteRenderer>().sprite = pop;
            if (!die)
            {
                level.player.GetComponent<CircleCollider2D>().radius = 0.3f;
                die = true;
                level.player.life--;
                numbersOfLife.text = "x" + level.player.life.ToString();
                if (level.sound)
                {
                    source.clip = clip;
                    source.Play();
                }
                level.player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                StartCoroutine(WaitForIt(1F));
            }
        }
    }

    IEnumerator WaitForIt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        level.player.GetComponent<SpriteRenderer>().sprite = level.currentSprite;
        level.player.transform.position = level.currentCheckPoint;
        level.player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        level.player.GetComponent<CircleCollider2D>().radius = level.currentRadius;
        die = false;
    }
    
}
