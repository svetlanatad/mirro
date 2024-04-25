using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public TextMeshProUGUI presse;
    public TextMeshProUGUI lose;
    public Button loseButton;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            lose.gameObject.SetActive(true);
            loseButton.gameObject.SetActive(true);

            presse.gameObject.SetActive(false);
            Debug.Log("Enemy");
        }
        Debug.Log("Lost");
    }
}
