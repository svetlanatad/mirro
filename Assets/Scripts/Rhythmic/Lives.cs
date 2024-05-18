using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int maxHealth = 3;
    public Image[] heartIcons;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered");
        ReduceHealth();
        Destroy(collision.gameObject);
        if(collision.gameObject.name == "End")
        {
            SceneManager.LoadScene("Cheers");
        }
    }

    

    private void ReduceHealth()
    {
        currentHealth--;
        UpdateHeartIcons();

        if (currentHealth <= 0)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void UpdateHeartIcons()
    {
        for (int i = 0; i < heartIcons.Length; i++)
        {
            if (i < currentHealth)
            {
                heartIcons[i].gameObject.SetActive(true);
            }
            else
            {
                heartIcons[i].gameObject.SetActive(false);
            }
        }
    }
}
