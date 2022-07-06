using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StrokeManager : MonoBehaviour
{
    public GameObject Ball;
    Transform playerBallTransform;

 
    void Start()
    {
        playerBallTransform = GameObject.FindGameObjectWithTag("Player").transform;
        FindPlayerBall();
    }

    void CheckRollingStatus()
    {

        if (playerBallRB.IsSleeping())
        {
            StartCoroutine("Example");
        }
        else
        {
        }

    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("mainmenu");
    }    
    Rigidbody playerBallRB;

    private void FindPlayerBall()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player"); // slow and dumb and could do badness

        if (go == null)
        {
            Debug.LogError("Couldn't find the ball.");
        }

        playerBallRB = go.GetComponent<Rigidbody>();

        if (playerBallRB == null)
        {
            Debug.LogError("Ball has no rigidbody?!?!?");
        }
    }

    // Update is called once per visual frame -- use this for inputs

    void FixedUpdate()
    {
        if (playerBallRB == null)
        {
            // Might not be an error -- maybe the ball fell out of bounds, got deleted,
            // and hasn't respawned yet.
            return;
        }
    }
}