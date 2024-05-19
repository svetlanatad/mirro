using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdolLocChange : MonoBehaviour
{
    [SerializeField] private Transform idol;
    [SerializeField] private Transform stageLoc;
    [SerializeField] private Transform barLoc;
    bool doorCheck;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && gameObject.name == "stageEnt")
        {
            idol.position = stageLoc.position;   
        }
        if (collision.gameObject.tag == "Player" && gameObject.name == "BarEnt")
        {
            idol.position = barLoc.position;
        }
    }

}
