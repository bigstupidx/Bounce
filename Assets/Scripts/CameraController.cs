using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public Transform leftBoder;
    public Transform rightBorder;
    public Transform upBorder;
    public Transform downBorder;
    public float widthCam;
    public float heightCam;
    public float widthMap;
    public float heightMap;
    public float widthBlock;
    public float distanceToLeftBorder;
    public float distanceToRightBorder;
    public float distanceToUpBorder;
    public float distanceToDownBorder;
    public int currentfloor;
    public int currentPlayerFloor;

    public float smooth;

    public Vector3 offset;
    public Vector3 begin;

    // Use this for initialization
    void Start()
    {
        Camera cam = Camera.main;
        widthCam = cam.orthographicSize;
        heightCam = cam.aspect;
        widthMap = rightBorder.position.x - leftBoder.position.x;
        heightMap = upBorder.position.y - downBorder.position.y;
        offset = transform.position - target.position;

        begin = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCameraWithWidth();
        MoveCameraWithHeight();
    }

    public void MoveCameraWithWidth()
    {
        distanceToLeftBorder = target.position.x - leftBoder.position.x;
        distanceToRightBorder = widthMap - distanceToLeftBorder;
        if (distanceToLeftBorder > widthCam && distanceToRightBorder > widthCam)
        {
            Vector3 targetCamPos = new Vector3(target.position.x, transform.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, targetCamPos, smooth * Time.deltaTime);
        }
        else if (distanceToLeftBorder < widthCam)
        {
            MoveCameraWithHeight();
            transform.position = Vector3.Lerp(transform.position, begin, smooth * Time.deltaTime);
        }
    }

    public void MoveCameraWithHeight()
    {
        distanceToDownBorder = target.position.y - downBorder.position.y;
        distanceToUpBorder = heightMap - distanceToDownBorder;

        Vector3 targetCamPos = new Vector3(transform.position.x, 0, transform.position.z);
        int k = (int)((target.position.y + 3.79f )/8.75);
        targetCamPos = targetCamPos + (new Vector3(0, 8.75f, 0) * k);
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smooth * Time.deltaTime);

    }



}
