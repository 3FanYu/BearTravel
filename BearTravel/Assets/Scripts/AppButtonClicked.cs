using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AppButtonClicked : MonoBehaviour {
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    public Flowchart talkFlowchart;
    public string onCollosionEnter;

    
    public GameObject[] Maps;
    
    
    int MapNumber;
    
    // Use this for initialization
    void Start () {
        MapNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (GvrControllerInput.AppButtonDown)
        {
            clicked++;
            if (clicked == 1) clicktime = Time.time;
        }
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            //return true;
            print("double");
            if (MapNumber == 0) return;
            
            MapNumber -= 1;
            this.GetComponent<MoveCam>().SetDestination(Maps[MapNumber].transform);
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
        else if (clicked == 1 && Time.time - clicktime > clickdelay) {
            print("single");
            
            
            MapNumber += 1;
            if (MapNumber == 3)
            {
                Block targetBlock = talkFlowchart.FindBlock(onCollosionEnter);
                talkFlowchart.ExecuteBlock(targetBlock);
                MapNumber = 2;
                
            }
            this.GetComponent<MoveCam>().SetDestination(Maps[MapNumber].transform);
            clicked = 0;
            clicktime = 0;
        }
        //return false;
    }
    
   

}

