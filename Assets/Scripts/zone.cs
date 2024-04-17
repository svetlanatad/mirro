using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class zone : MonoBehaviour

{
    public TextMeshProUGUI interactionTextUI; // Reference to the TextMeshProUGUI element displaying interaction prompt
    public TextMeshProUGUI presse;
    // Start is called before the first frame update
    void Start()
    {
        interactionTextUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Parcel")) {
            interactionTextUI.gameObject.SetActive(true);
            presse.gameObject.SetActive(false);
        }
    }
}
