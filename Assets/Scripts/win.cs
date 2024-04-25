using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public TextMeshProUGUI interactionTextUI; // Reference to the TextMeshProUGUI element displaying interaction prompt
    public TextMeshProUGUI presse;
    public bool active = false; 
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && !active)
        {
            interactionTextUI.gameObject.SetActive(active);
            Debug.Log("Won");
            presse.gameObject.SetActive(false);
        }
	
            presse.gameObject.SetActive(false);
        Debug.Log("aaa");

    }
}
