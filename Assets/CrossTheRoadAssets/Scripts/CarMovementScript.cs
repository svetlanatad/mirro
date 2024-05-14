using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementScript : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.003f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.CompareTag("bounds")){
            Destroy(gameObject);
        }
    }
}
