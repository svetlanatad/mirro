using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private bool canBePressed;
    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        canBePressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag != "Holder")
        {
            if (Input.GetKeyDown(keyToPress) && canBePressed)
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            if (Input.GetKey(keyToPress) && canBePressed)
            {
                gameObject.SetActive(false);
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Activator")
        {
            canBePressed = true;
            Debug.Log("Enter");
        }
    } private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}
