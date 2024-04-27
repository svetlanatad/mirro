using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TugOfWarController : MonoBehaviour
{
    public float speed = 5f;
    public float force = 0.5f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.AddForce(Vector2.left * force*7f, ForceMode2D.Impulse);
            
        }
//add bool later
        rb.AddForce(Vector2.right * force/17, ForceMode2D.Impulse);

    }
}
