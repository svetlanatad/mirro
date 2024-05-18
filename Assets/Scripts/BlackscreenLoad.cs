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
            if (gameObject.name == "Changer1")
            {
                SceneManager.LoadScene("GoingToStage");
            }
            if (gameObject.name == "Changer2")
            {
                SceneManager.LoadScene("MeetingFather");
            }
        }
    }

}
