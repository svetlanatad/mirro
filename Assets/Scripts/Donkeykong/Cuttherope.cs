using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cuttherope : MonoBehaviour
{
    public TextMeshProUGUI interactionTextUI;
    bool isIn = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactionTextUI.gameObject.SetActive(true);
            isIn = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactionTextUI.gameObject.SetActive(false);
            isIn = false;

        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&isIn)
        {
            Debug.Log("Pressed");
            GameObject objectToFind = GameObject.FindWithTag("Light");
            if (objectToFind != null)
            {
                Rigidbody2D rb2d = objectToFind.GetComponent<Rigidbody2D>();
                if (rb2d != null)
                {
                    rb2d.gravityScale = 1f;
                }
            }
        }
    }
}
