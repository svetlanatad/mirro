using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TugOfWarController : MonoBehaviour
{
    private float speed = 2f;
    private float force = 45f;
    public Rigidbody2D rb;
    private float cooldownDuration = 0.01f; 
    private float cooldownTimer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Update the cooldown timer
        if (cooldownTimer > 0f)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        float movement = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.E) && cooldownTimer <= 0f)
        {
            rb.AddForce(Vector2.left * force);
            cooldownTimer = cooldownDuration;
        }
        else
        {
            rb.AddForce(Vector2.right * force);
        }

        
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, speed);
    }
}
