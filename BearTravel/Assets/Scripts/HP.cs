using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class HP : MonoBehaviour {
 
	private float MaxHp;
	private float Hp;
    public float time;
    private float timeLeft;
    public GameObject HPgram;
    public GameObject OGsaydialog;
    public GameObject OGmenudialog;
    bool GameStart = false;
    public Flowchart talkFlowchart;
    static int QuestionTimes=0;
    // Use this for initialization
    void Start () {
        float timeLeft = time;
        MaxHp = time;
	}

    // Update is called once per frame
    void Update()
    {
        if (GameStart)
        {
            timeLeft -= Time.deltaTime;
            Hp = timeLeft;
            if (timeLeft < 0)
            {
                /*cube.SetActive(true);
                if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold)
                {
                    cube.SetActive(false);*/

                if (QuestionTimes <= 2)
                {
                    
                    if (QuestionTimes==1) {
                        GameObject.Find("Systems").GetComponent<Attention>().activation=true;
                    }
                    else if (QuestionTimes == 2)
                    {
                        OGmenudialog.SetActive(false);
                        OGsaydialog.SetActive(false);
                        Block targetBlock = talkFlowchart.FindBlock("Q2");
                        talkFlowchart.ExecuteBlock(targetBlock);
                        QuestionTimes = 0;
                        HPgram.SetActive(false);


                    }
                    QuestionTimes += 1;
                }
                
                                
                timeLeft = time;
            }
            this.transform.localPosition = new Vector3((-478 + 478 * (Hp / MaxHp)), 0.0f, 0.0f);
        }
    }
    public void SetGameStart() {
        GameStart = true;
    }
    }

