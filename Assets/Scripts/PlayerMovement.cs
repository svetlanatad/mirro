using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; // Movement speed

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
        rb.gravityScale = 0f; // Set gravity scale to zero
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        if(gameObject.tag != "MainCamera")
        {
            float moveVertical = Input.GetAxisRaw("Vertical");
            movement = new Vector2(moveHorizontal, moveVertical).normalized * speed * Time.deltaTime;
        }
        else
        {
            movement = new Vector2(moveHorizontal, 0f).normalized * speed * Time.deltaTime;


        }
        rb.MovePosition(rb.position + movement);
    }
}
