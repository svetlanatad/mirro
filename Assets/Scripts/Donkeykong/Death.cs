using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Light")
        {
            StartCoroutine(ChangeSceneAfterDelay());
        }
    }
    private IEnumerator ChangeSceneAfterDelay()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("RealGoingStage");
    }
}
