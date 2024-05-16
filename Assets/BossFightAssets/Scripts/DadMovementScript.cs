using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DadMovementScript : MonoBehaviour
{
    [SerializeField] private GameObject Mirro;
    [SerializeField] private float speed;
    [SerializeField] private float chargeSpeed;
    [SerializeField] private float chargeCooldown;

    private bool toCharge = false;
    private Vector3 targetPos;
    private Vector3 direction;
    private int dadHP = 4;



    // Update is called once per frame
    private void Update()
    {
        {
            if (toCharge == true)
            {
                chargeTowardsPlayer();
            }
            if (!toCharge)
            {
                MoveTowardsPlayer();
            }

        }
    }
    private void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, Mirro.transform.position, speed);

    }
    private void chargeTowardsPlayer()
    {
        Debug.Log("raaaaaa");
        transform.Translate(direction * 1.4f * Time.deltaTime);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("wall"))
        {
            toCharge = false;
            dadHP--;
            Debug.Log("oop touched a wall ow");
        }
        

    }
    void Start()
    {
       
        StartCoroutine(SavePosition2());


    }

    IEnumerator SavePosition2()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            targetPos = Mirro.transform.position;
            yield return new WaitForSeconds(0.5f);
            toCharge = true;
            direction = targetPos - transform.position;


            // yield return new WaitForSeconds(2f);
            // toCharge = false;
        }
    }
}



