using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMoveTowardsObjectScript : MonoBehaviour
{

    // Start is called before the first frame update
    private int MoveCount = 0;
    private int MoveCount2 = 13;
    private float MoveDistance = 1.3f;
    [SerializeField] GameObject Mirro;
    [SerializeField] GameObject Mirrofront;
    [SerializeField] TextMeshProUGUI text;

    bool check;
    int count = 0;

    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()

    {

        if (Input.GetKeyDown("space"))
        {
            move();
            ChangeMirro();
            CheckIncrement();
        }

        if (count >= 2)
        {
            SceneManager.LoadScene("Crossed");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Reverse")
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
        Destroy(text);
        if (MoveCount <= 12)
        {
            if (MoveCount % 3 == 0 && MoveCount != 0 && MoveCount < 10)
            {
                MoveDistance /= 1.35f;
                Mirro.transform.localScale /= 1.2f;
                transform.position -= new Vector3(0, 0.18f, 0);


            }
            transform.position += new Vector3(0, MoveDistance, 0);

            MoveCount++;
            Debug.Log(MoveCount);
        }

        // transform.position += new Vector3(0, MoveDistance, 0);
        //Debug.Log(MoveCount);

        if (MoveCount >= 13)
        {
            if (MoveCount2 % 3 == 0 && MoveCount2 != 0 && MoveCount2 < 10)
            {
                MoveDistance *= 1.35f;
                Mirrofront.transform.localScale *= 1.2f;
                transform.position += new Vector3(0, 0.18f, 0);
                Debug.Log("test");


            }
            transform.position -= new Vector3(0, MoveDistance, 0);
            MoveCount2--;
            //MoveCount++;
        }

    }
    public void ChangeMirro()
    {
        if (MoveCount >= 13 && MoveCount2 == 12)
        {
            // Instantiate(Mirrofront, gameObject.transform.position, Quaternion.identity);
            Mirrofront.SetActive(true);
            Destroy(Mirro);
            MoveCount++;

        }
    }
    private void CheckIncrement()
    {
        if (MoveCount == 13)
        {
            count++;
        }
        if (MoveCount2 == 0)
        {
            count++;
        }
    }

}
