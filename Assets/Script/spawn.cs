
using System.Collections;
using UnityEngine;


public class spawn : MonoBehaviour
{
    public GameObject kirigi;

    void Start()
    {
        StartCoroutine(Spawnitem());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawnitem()
    {
        yield return new WaitForSeconds(1f);
        Vector3 pos = new Vector3(Random.Range(-4f, -12f), 85f, 0f);
        Instantiate(kirigi, pos, Quaternion.identity);
        yield return new WaitForSeconds(1f);

       
        
    }
   
  
    }

