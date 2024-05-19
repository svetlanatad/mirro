using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Light;
    public float delaySeconds = 2f;
    public GameObject Sound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Light")
        {
            StartCoroutine(ChangeSceneAfterDelay());
        }
    }
    private IEnumerator ChangeSceneAfterDelay()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("RealGoingStage");
    }
    public void Tadam()
    {
        Light.gravityScale = 1.0f;
        StartCoroutine(EnableObjectAfterDelay());
    }
    private IEnumerator EnableObjectAfterDelay()
    {
        
        yield return new WaitForSeconds(delaySeconds);       
        Sound.SetActive(true);
    }

}
