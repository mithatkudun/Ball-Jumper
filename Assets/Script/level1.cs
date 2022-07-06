using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{
    public LevelScript LevelScript;

    public GameObject finish;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            StartCoroutine("ForExample");
            LevelScript.Pass();
        }
    }

    IEnumerator ForExample()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Destroy(finish, 0);
    }
    void Update()
    {
        
    }
}
