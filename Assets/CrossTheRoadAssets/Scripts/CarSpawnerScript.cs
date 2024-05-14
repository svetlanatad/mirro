using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(Spawner());
    
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Spawner()
    {
        while (true)
        {
            float spawnDelay = Random.Range(2f, 3f);
            yield return new WaitForSeconds(spawnDelay);
            Instantiate(Car, transform.position, Quaternion.identity);
        }
    }
}
