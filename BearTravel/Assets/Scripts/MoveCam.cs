using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {
    private Vector3 endpos;
    private float lerptime = 5;
    private float currentlerptime = 0;
    private bool key = false;
    private Vector3 startpos;
    public GameObject Player;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        startpos = Player.transform.position;
        if (key == true)
        {
            currentlerptime += Time.deltaTime;
            if (currentlerptime >= lerptime)
            {
                currentlerptime = lerptime;
            }
            float perc = currentlerptime / lerptime;

            Player.transform.position = Vector3.Lerp(startpos, endpos, perc);
        }
    }
    public void SetDestination(Transform Target)
    {
        endpos = Target.position;
        key = true;
        lerptime = 5;
        currentlerptime = 0;
    }
}
