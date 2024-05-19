using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdolLocChange : MonoBehaviour
{
    [SerializeField] private GameObject idol;
    [SerializeField] private Transform stageLoc;
    [SerializeField] private Transform barLoc;
    bool doorCheck;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && gameObject.name == "stageEnt")
        {
            idol.transform.position = stageLoc.position;   
            idol.GetComponent<Collider2D>().enabled = false;
        }
        if (collision.gameObject.tag == "Player" && gameObject.name == "barEnt")
        {
            idol.GetComponent<Collider2D>().enabled = true;
            idol.transform.position = barLoc.position;
        }
    }

}
