
using System.Collections;
using UnityEngine;


public class spawner : MonoBehaviour
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
        Vector3 pos = new Vector3(Random.Range(-32f, -47f), -97f, 0f);
        Instantiate(kirigi, pos, Quaternion.identity);
        yield return new WaitForSeconds(1f);



    }


}


