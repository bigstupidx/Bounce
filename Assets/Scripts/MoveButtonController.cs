using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButtonController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public PlayerController playerMove;

    // Use this for initialization
    void Start()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Button Left")
        {
            if(playerMove.wallRight)
            {
                playerMove.speed = 300;
            }
            if (!playerMove.wallLeft)
            {
                playerMove.SetMoveLeft(true);
                playerMove.move = -1;
            }
        }
        else if (gameObject.name == "Button Right")
        {
            if (playerMove.wallLeft)
            {
                playerMove.speed = 300;
            }
            if (!playerMove.wallRight)
            {
                playerMove.SetMoveRight(true);
                playerMove.move = 1;
            }


        }
        else if (gameObject.name == "Button Jump")
        {
            playerMove.SetJump(true);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (gameObject.name == "Button Left")
        {
            playerMove.SetMoveLeft(false);
            playerMove.move = 0;
        }
        else if (gameObject.name == "Button Right")
        {
            playerMove.SetMoveRight(false);
            playerMove.move = 0;
        }
        else if (gameObject.name == "Button Jump")
        {
            playerMove.SetJump(false);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
