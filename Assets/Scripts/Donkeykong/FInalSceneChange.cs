using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FInalSceneChange : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Light")
        {
            SceneManager.LoadScene("Death");
        }
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("H_Donkey Kong");
        }
    }
}
