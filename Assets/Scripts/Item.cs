using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Item : MonoBehaviour
{

    private bool inRange = false; // Flag to track if the player is in range for interaction
    //make private
    public TextMeshProUGUI interactionTextUI; // Reference to the TextMeshProUGUI element displaying interaction prompt

    private void Start()

    {
        Debug.Log("debug works");
        // Find the TextMeshProUGUI element in the scene
        interactionTextUI = GameObject.Find("InteractionText").GetComponent<TextMeshProUGUI>();

        // Hide the TextMeshProUGUI element initially
        interactionTextUI.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("collision deteceted");
            inRange = true;
            //interactionTextUI.text = "Press E";
            interactionTextUI.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))


        {

            Debug.Log("collision deteceted off");

            // Hide interaction prompt when player is no longer colliding with the object
            inRange = false;
            interactionTextUI.gameObject.SetActive(false);
        }
    }

   

    private void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            // Load the next scene when player interacts with the object
            SceneManager.LoadScene("OuterCity");
        }
    }

    // Load the next scene after interaction is finished
    private void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
