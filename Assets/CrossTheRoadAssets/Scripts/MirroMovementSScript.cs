using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MirroMovementSScript : MonoBehaviour
{
    
   

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Enemy").transform.position, 0.006f);

    }


    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.transform.tag.Equals("car"))
        {
            Debug.Log("boop");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        

    }
    
}
