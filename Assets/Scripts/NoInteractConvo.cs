using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoInteractConvo : MonoBehaviour
{
    [SerializeField] private NPCConversation myConvo;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Debug.Log("entered");
            ConversationManager.Instance.StartConversation(myConvo);
        }
    }
}
