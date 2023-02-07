using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    public bool vid1Status;
    private VideoPlayer vid1;
    
    public bool vid2Status;
    private VideoPlayer vid2;

    public bool vid3Status;
    private VideoPlayer vid3;

    void Start()
    {
        vid1Status = false;
        vid2Status = false;
        vid3Status = false;
    }

    void Play(){
        if(Input.GetKeyDown(KeyCode.A)){
            vid1 = GetComponent<VideoPlayer>();
            vid1.Pause();
        }else if(Input.GetKeyDown(KeyCode.S)){
            vid2 = GetComponent<VideoPlayer>();
            vid2.Pause();
        }else if(Input.GetKeyDown(KeyCode.S)){
            vid3 = GetComponent<VideoPlayer>();
            vid3.Pause();
        }
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && vid1Status == false){
            vid1.Play();
            vid1Status = true;
        }else if(Input.GetKeyDown(KeyCode.Space) && vid1Status == true){
            vid1.Pause();
            vid1Status = false;
        }

        if(Input.GetKeyDown(KeyCode.S) && vid2Status == false){
            vid2.Play();
            vid2Status = true;
        }else if(Input.GetKeyDown(KeyCode.Space) && vid2Status == true){
            vid2.Pause();
            vid2Status = false;
        }
        
        if(Input.GetKeyDown(KeyCode.D) && vid3Status == false){
            vid3.Play();
            vid3Status = true;
        }else if(Input.GetKeyDown(KeyCode.Space) && vid3Status == true){
            vid3.Pause();
            vid3Status = false;
        }
    }
}
