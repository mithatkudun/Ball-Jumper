
using System.Collections;
using UnityEngine;


public class spawn12 : MonoBehaviour
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
        Vector3 pos = new Vector3(Random.Range(-16f, -30f), -97f, 0f);
        Instantiate(kirigi, pos, Quaternion.identity);
        yield return new WaitForSeconds(1f);



    }


}


