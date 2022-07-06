using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public float timeLeft = 30f;
    public Text text1;
    Rigidbody playerBallRB;
    public GameObject tryagainui;
    public GameObject text12;

    private void Start()
    {
        FindPlayerBall();
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            playerBallRB.constraints = RigidbodyConstraints.FreezeAll;
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownDisplay.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
    }
 void Update()
    {
        if (countdownTime == 0)
        {   
            playerBallRB.constraints = RigidbodyConstraints.None;
            playerBallRB.constraints = RigidbodyConstraints.FreezePositionZ;
            countdownDisplay.gameObject.SetActive(false);
            StopCoroutine(CountdownToStart());
            timeLeft -= Time.deltaTime;
            text1.text = (timeLeft).ToString("0");
            text1.text = "" + timeLeft + "";
        }
        if (timeLeft < 0)
        {
            tryagainui.SetActive(true);
            Time.timeScale = 1.0f;
            text12.SetActive(false);
            playerBallRB.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    public void FindPlayerBall()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        playerBallRB = go.GetComponent<Rigidbody>();
        if(playerBallRB == null)
        {
            Debug.LogError("no rigidbody");
        }
    }
}
