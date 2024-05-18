using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMoveTowardsObjectScript : MonoBehaviour
{

    // Start is called before the first frame update
    private int MoveCount = 0;
    private float MoveDistance = 1.3f;
    [SerializeField] GameObject Mirro;
    bool check;
    int count=0;

    // Update is called once per frame
    void Update()

    {
        if (check)
        {
            MoveDistance = -MoveDistance;
            check = false;
        }
        if (Input.GetKeyDown("space"))
        {
            move();
        }

        if (count >= 2)
        {
            SceneManager.LoadScene("Crossed");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Reverse")
        {
            check = true;
            Debug.Log("Hell Yeah");
        }
        if (collision.gameObject.tag == "wall")
        {
            count++;
            Debug.Log(count);
        }
    }
    public void move()
    {
        if (MoveCount % 3 == 0 && MoveCount != 0 && MoveCount < 10)
        {
            MoveDistance /= 1.35f;
            Mirro.transform.localScale /= 1.2f;
          transform.position -= new Vector3(0, 0.18f, 0);
           
            
        }


        transform.position += new Vector3(0, MoveDistance, 0);
        //Debug.Log(MoveCount);
        MoveCount++;




    }
}
