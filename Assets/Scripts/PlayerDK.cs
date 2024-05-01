using UnityEngine;

public class PlayerDK : MonoBehaviour {

private Rigidbody2D rb;
private Vector2 direction;
public float moveSpeed = 1f;
private void Awake()
{

rb = GetComponent<Rigidbody2D>();

}
private void Update()
{

direction.x = Input.GetAxis("Horizontal") * moveSpeed;
direction.y = Input.GetAxis("Vertical") * moveSpeed;

}

private void FixedUpdate()
{

rb.MovePosition(rb.position + direction * Time.fixedDeltaTime);
}

}
