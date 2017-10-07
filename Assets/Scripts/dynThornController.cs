using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dynThornController : MonoBehaviour
{

    public float speed;
    public bool up;
    public bool left;

    public BoxCollider2D borderUp;
    public BoxCollider2D borderDown;
    public float widthBlock;

    public LevelController level;

    public Sprite pop;
    public Text numbersOfLife;
    bool die;

    public AudioClip clip;
    public AudioSource source;

    private float l;
    private float k;
    private float m;



    // Use this for initialization
    void Start()
    {
        widthBlock = 1.25f;
        speed = 0.01f;
        up = false;
        level = FindObjectOfType<LevelController>();
        numbersOfLife = GameObject.FindGameObjectWithTag("noLife").GetComponentInChildren<Text>();
        die = false;
        source = level.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotation();
        Move();

    }

    void Move()
    {
        if (up)
        {
            this.transform.Translate(new Vector3(0, 1, 0) * speed);
        }
        else
        {
            this.transform.Translate(new Vector3(0, -1, 0) * speed);
        }
    }

    void rotation()
    {
        if(left)
        {
            k = (borderUp.transform.position.x + (7 * widthBlock / 2));
            m = (borderDown.transform.position.x - (7 * widthBlock / 2));
            l = this.transform.position.x;
            if (this.transform.position.x < (borderUp.transform.position.x + (5 * widthBlock / 2)))
            {
                up = false;
            }
            if (this.transform.position.x > (borderDown.transform.position.x - (3 * widthBlock / 2)))
            {
                up = true;
            }
        }
        else
        {
            if (this.transform.position.y > (borderUp.transform.position.y - (3 * widthBlock / 2)))
            {
                up = false;
            }
            if (this.transform.position.y < (borderDown.transform.position.y + (3 * widthBlock / 2)))
            {
                up = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            level.player.GetComponent<SpriteRenderer>().sprite = pop;
            if (die == false)
            {
                die = !die;
                level.player.life--;
                numbersOfLife.text = "x" + level.player.life.ToString();
                if(level.sound)
                {
                    source.clip = clip;
                    source.Play();
                }
            }
            StartCoroutine(WaitForIt(0.5F));
        }
    }

    IEnumerator WaitForIt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        level.player.GetComponent<SpriteRenderer>().sprite = level.currentSprite;
        level.player.GetComponent<CircleCollider2D>().radius =
                level.currentRadius;
        if (level.currentRadius == 0.8f)
        {
            level.player.bold = false;
        }
        level.player.transform.position = level.currentCheckPoint;
        level.player.transform.rotation = level.player.originalRotation;
        level.player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        level.player.GetComponent<Rigidbody2D>().angularVelocity = 0;
        level.player.GetComponent<Rigidbody2D>().gravityScale = level.player.currentGravity;

        die = false;

    }

}
