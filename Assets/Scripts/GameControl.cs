using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroid;
    public Vector3 randomPos;
    void Start()
    {
        StartCoroutine(asteroidCreate());
    }

    IEnumerator asteroidCreate()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));
        while (true)
        {
            for (int i = 0; i < Random.Range(5, 15); i++)
            {
                Vector3 vec = new Vector3(Random.Range(-1 * randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(0.7f, 5));
            }
            yield return new WaitForSeconds(Random.Range(2, 5));
        }


    }

}
