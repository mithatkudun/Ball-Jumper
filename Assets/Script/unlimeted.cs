using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class unlimeted : MonoBehaviour
{

    public GameObject item;

    void Start()
    {
        
    }

    void spawnitem()
    {
        Vector3 position = new Vector3(Random.Range(-29, 29), Random.Range(-15, 75f), -0.5f);
        Instantiate(item, position, Quaternion.identity);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            
            Destroy(item, 0);
            spawnitem();

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            
        }
    }
}

