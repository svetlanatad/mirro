using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DadFight : MonoBehaviour
{
    public void Fight()
    {
        SceneManager.LoadScene("BossFightScene");
    }
}
