using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomChange : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Mirro")
        {
            

                if (gameObject.name == "Father" && Input.GetKey(KeyCode.W))
                {
                    SceneManager.LoadScene("1_father_room");
                    Debug.Log("ENtered fathers room");
                }
                if (gameObject.name == "Mother" && Input.GetKey(KeyCode.S))
                {
                    SceneManager.LoadScene("2_mother_room");

                }
                if (gameObject.name == "Basement" && Input.GetKey(KeyCode.D))
                {
                    SceneManager.LoadScene("Start");
                }
              
                if((gameObject.name == "Father" && Input.GetKey(KeyCode.S)) || (gameObject.name == "Mother" && Input.GetKey(KeyCode.W)) || (gameObject.name == "Basement" && Input.GetKey(KeyCode.A)))
                {
                SceneManager.LoadScene("0_house_starting");
                StartCoroutine(SetPlayerPosition());
            }





        }
       

    }
    private IEnumerator SetPlayerPosition()
    {
        yield return new WaitForSeconds(0.1f); 

        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            player.GetComponent<Rigidbody2D>().position = new Vector2(14.64f, 0.10f);
        }
        else
        {
            Debug.LogError("Player game object not found!");
        }
    }



}
