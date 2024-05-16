using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float dodgeDistance = 2f; // Adjust this to change the distance of the dodge
    public float dodgeCooldown = 1f; // Adjust this to change the cooldown duration
    public LayerMask obstacleLayer; // Define the layer containing walls

    private Vector3 lastMovementDirection;
    private float dodgeCooldownTimer;
    private bool isTouchingWall;

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Check if the player is moving
        if (movementDirection.magnitude > 0)
        {
            lastMovementDirection = movementDirection; // Store the last movement direction
        }

        // Update the dodge cooldown timer
        dodgeCooldownTimer -= Time.deltaTime;
        dodgeCooldownTimer = Mathf.Max(0f, dodgeCooldownTimer); // Ensure the timer doesn't go below zero

        // Dodge mechanic
        if (Input.GetKeyDown(KeyCode.Space) && dodgeCooldownTimer <= 0 && !isTouchingWall)
        {
            // Move the player a short distance in the direction they were moving
            transform.position += lastMovementDirection * dodgeDistance;

            // Start the cooldown timer
            dodgeCooldownTimer = dodgeCooldown;
        }
        else
        {
            // Move the player normally
            transform.position += movementDirection * moveSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            isTouchingWall = true;
        }
        if(collision.gameObject.CompareTag("Enemy")){
             int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
              SceneManager.LoadScene(currentSceneIndex);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            isTouchingWall = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            isTouchingWall = false;
        }
    }
}
