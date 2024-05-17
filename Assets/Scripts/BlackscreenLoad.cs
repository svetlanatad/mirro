using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackscreenLoad : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Mirro")
        {
            if(gameObject.name == "Changer")
            {
                SceneManager.LoadScene("OuterCity 1");
            }
        }
    }

}
