using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Play1 : MonoBehaviour
{

    // Boolean to check if the video is playing
    public bool vid1Status;
    private VideoPlayer vid1;


    void Start()
    {
        // Initialize the video player
        // Turn playOnAwake off
        vid1 = GetComponent<VideoPlayer>();
        vid1.playOnAwake = false;
        vid1Status = false;

    }

    void Update()
    {
        vid1.enabled = true;
        
        // Play video when 'A' is pressed
        // Pause video when 'Space' or 'A' is pressed again
        // Turn off video when any of the other video starts playing (When 'S' or 'D' is pressed)
        if(Input.GetKeyDown(KeyCode.A) && vid1Status == false){
            vid1.Play();
            vid1Status = true;
        }else if((Input.GetKeyDown(KeyCode.Space) && vid1Status == true || (Input.GetKeyDown(KeyCode.A) && vid1Status == true))){
            vid1.Pause();
            vid1Status = false;
            
        }else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)){
            vid1.enabled = false;
            vid1Status = false;
        }

        // Turn off video when 'T' is pressed
        if(Input.GetKeyDown(KeyCode.T)){
            vid1.enabled = false;
        }
    }
}
