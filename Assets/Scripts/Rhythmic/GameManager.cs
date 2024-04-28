using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource music;
    public bool startPlay;
    public BeatScroll theBS;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlay)
        {
            if (Input.anyKeyDown)
            {
                startPlay = true;
                theBS.started = true;
                music.Play();
            }
        }
    }
}
