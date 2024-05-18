using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterRythmicGame : MonoBehaviour
{
    bool entered = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Mirro")
        {
            entered = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Mirro")
        {
            entered = false;
        }
    }
    private void Update()
    {
        if(entered && Input.GetKeyUp(KeyCode.E))
        {
            SceneManager.LoadScene("Rythmic Game");
        }
    }
}
