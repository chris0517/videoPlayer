using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public GameObject tmpValue;

    public Play1 script1;
    public Play2 script2;
    public Play3 script3;

    public string val;

    TextMeshProUGUI textValue;
    void Start()
    {
        val = "No Video Playing";
        textValue = tmpValue.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textValue.text = val;

        if(script1.vid1Status){
            val = "Playing Video 1";
        }else if(script2.vid2Status){
            val = "Playing Video 2";
        }else if(script3.vid3Status){
            val = "Playing Video 3";
        }

        if(Input.GetKeyDown(KeyCode.T)){
            val = "No Video Playing";
        }
    }
}
