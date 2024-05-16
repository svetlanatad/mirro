using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Presets;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public TextMeshProUGUI interactionTextUI; // Reference to the TextMeshProUGUI element displaying interaction prompt

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactionTextUI.gameObject.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactionTextUI.gameObject.SetActive(false);

        }
    }
}
