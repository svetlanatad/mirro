using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntertheStage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Mirro")
        {
            SceneManager.LoadScene("Pub");
            if(gameObject.name == "ToDonkeyKong")
            {
                SceneManager.LoadScene("H_Donkey Kong");
            }
            if(gameObject.name == "aa")
            {
                SceneManager.LoadScene("Stage");
            }
        }
        
    }
}
