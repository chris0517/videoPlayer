using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Play3 : MonoBehaviour
{
    // Boolean to check if the video is playing
    public bool vid3Status;
    private VideoPlayer vid3;
    
    void Start()
    {
        // Initialize the video player
        // Turn playOnAwake off
        vid3 = GetComponent<VideoPlayer>();
        vid3.playOnAwake = false;
        vid3Status = false;

    }

    void Update()
    {
        vid3.enabled = true;
        
        // Play video when 'D' is pressed
        // Pause video when 'Space' or 'D' is pressed again
        // Turn off video when any of the other video starts playing (When 'S' or 'D' is pressed)
        if(Input.GetKeyDown(KeyCode.D) && vid3Status == false){
            vid3.Play();
            vid3Status = true;
        }else if( (Input.GetKeyDown(KeyCode.Space) && vid3Status == true) || (Input.GetKeyDown(KeyCode.D) && vid3Status == true)){
            vid3.Pause();
            vid3Status = false;
            
        }else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A)){
            vid3.enabled = false;
            vid3Status = false;
        }

        // Turn off video when 'T' is pressed
        if(Input.GetKeyDown(KeyCode.T)){
            vid3.enabled = false;
        }
    }
}
