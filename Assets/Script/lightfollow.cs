using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightfollow : MonoBehaviour
{
    public Light followlight, followlight1, followlight2;


    public Camera MainCamera;
    Transform playerBallTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerBallTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void FixedUpdate() 
    {
        this.transform.position = playerBallTransform.position + new Vector3(0, 0, -7.4f);
        followlight.transform.position = playerBallTransform.position + new Vector3(0, 0.5f, -0.7f);
        followlight1.transform.position = playerBallTransform.position + new Vector3(0, 0.5f, -0.7f);
        followlight2.transform.position = playerBallTransform.position + new Vector3(0, 0.5f, -0.7f);
        MainCamera.transform.position = playerBallTransform.position + new Vector3(0, 7f, -20f);
    }
}
