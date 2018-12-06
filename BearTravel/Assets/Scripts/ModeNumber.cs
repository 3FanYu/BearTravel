using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeNumber : MonoBehaviour {
    public static int Mode;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Cmode()
    {
        Mode = 1;
    }
    public void Pmode()
    {
        Mode = 0;
    }
}
