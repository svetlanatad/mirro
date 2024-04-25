using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public TextMeshProUGUI presse;
    public TextMeshProUGUI lose;
    public TextMeshProUGUI interactionTextUI;
    public Button loseButton;
    public bool active = false;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy") && !active)
        {
            lose.gameObject.SetActive(active);
            loseButton.gameObject.SetActive(true);

            presse.gameObject.SetActive(false);
            Debug.Log("Enemy");
        }

	
        presse.gameObject.SetActive(false);
interactionTextUI.gameObject.SetActive(false);
        
        Debug.Log("Lost");
    }
}
