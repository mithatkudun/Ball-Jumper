using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finishgame : MonoBehaviour
{
    public GameObject Clock;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
                {
            StartCoroutine("Example");
        
        }
    }
    IEnumerator Example()
    {
        Destroy(Clock, 0);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("level");
    }
    IEnumerator AnOtherExample()
    {
        yield return new WaitForSeconds(3);
        Debug.LogError("Say Hi Bitch");
        
    }
    void    OnTriggerExit(Collider other)
{        
        if (other.transform.tag == "Player")
        {
            StopCoroutine("Example");
            StartCoroutine("AnOtherExample");
        }
        else
        {
            StopCoroutine("Example");
        }
    }
}