using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Respawn")
        {
            Destroy(GameObject.FindWithTag("Respawn"));
        }
    }
    void Update()
    {
        
    }
}
