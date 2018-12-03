using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Fungus;
using System.Linq;
using System.Text;
using System.Threading;

public class MP : MonoBehaviour {
    private float MaxMp;
    private float Mp;
    public float time;
    private float timeLeft;
    public Image Bar;
    public Flowchart timeFlowchart;
    public GameObject charts;
    // Use this for initialization
    void Start () {
        timeLeft = time;
        MaxMp = time;
    }
	
	// Update is called once per frame
	void Update () {
        

        timeLeft -= Time.deltaTime;
        Mp = timeLeft;
        Bar.fillAmount = Mp / MaxMp;
        if (timeLeft <= 0)
        {
            /*cube.SetActive(true);
            if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold)
            {
                cube.SetActive(false);*/
            Block targetBlock = timeFlowchart.FindBlock("timeout");
            timeFlowchart.ExecuteBlock(targetBlock);
            charts.SetActive(false);
            //timeLeft = time;

        }
    }
}

