using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            count++;
        }
    }
    private void Update()
    {
        if(count >= 2)
        {
            SceneManager.LoadScene("Crossed");
        }
    }
}
