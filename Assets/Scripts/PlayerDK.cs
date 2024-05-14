using UnityEngine;

public class PlayerDK : MonoBehaviour {


private Collider2D collider;
private new Collider2D[] results;
private new Rigidbody2D rb;
private Vector2 direction;
private bool grounded;
public float moveSpeed = 3f;
public float jumpForce = 3f;
private bool climbing;
private void Awake()
{

rb = GetComponent<Rigidbody2D>();
collider = GetComponent<Collider2D>();
results = new Collider2D[4];

}

private void CheckCollision(){


grounded = false;
Vector2 size = collider.bounds.size;
size.y += 0.1f;
size.x /= 2f;
int amount = Physics2D.OverlapBoxNonAlloc(transform.position, size, 0f, results);  

for(int i = 0; i < amount; i++){
GameObject hit = results[i].gameObject;

if(hit.layer == LayerMask.NameToLayer("Ground")){
    grounded = hit.transform.position.y < (transform.position.y - 0.3f); //modify the number it is the average distance between the head of mirro and the the platform head so if it may not work correctly for you ,not detecting collision, the number might be either too big or too small 
    //Physics2D.IgnoreCollision(collider, results[i], !grounded);
//apparently, the compiler couldn't differentiate the paranthesis in commented out lines, so be careful with those and indented comments absolutely dont work
} else if(hit.layer == LayerMask.NameToLayer("Ladder")){
}


}
}




private void Update()
{
CheckCollision();
if (Input.GetButtonDown("Jump") && grounded){

direction = Vector2.up * jumpForce;
}else{
direction += Physics2D.gravity * Time.deltaTime;
}
direction.x = Input.GetAxis("Horizontal") * moveSpeed;
if (grounded){

direction.y = Mathf.Max(direction.y, -1f); //ensures gravity is not higher than input

}
if(direction.x > 0f){


transform.eulerAngles = Vector3.zero;
}else{

transform.eulerAngles = new Vector3(0f, 180f, 0f);
}
}

private void FixedUpdate()
{

rb.MovePosition(rb.position + direction * Time.fixedDeltaTime);
}


}
 
