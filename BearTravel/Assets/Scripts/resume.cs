using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resume : MonoBehaviour {
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void restart() {
        SoundManagerScript.PlaySound("applaud");
        one.SetActive(true);
        two.SetActive(true);
        three.SetActive(true);
        four.SetActive(false);
        five.SetActive(false);
    }
}
