using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToMoveTowardsObjectScript : MonoBehaviour
{

    // Start is called before the first frame update
    private int MoveCount = 0;
    private float MoveDistance = 1.3f;
    [SerializeField] GameObject Mirro;

    // Update is called once per frame
    void Update()

    {

        if (Input.GetKeyDown("space"))
        {
            move();
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
        Debug.Log(MoveCount);
        MoveCount++;




    }
}
