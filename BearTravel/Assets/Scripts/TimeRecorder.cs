using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRecorder : MonoBehaviour {
    public static float TimeSpent;
    bool recorder = true;
    // Use this for initialization
    void Start() {
        TimeSpent = 0f;
    }

    // Update is called once per frame
    void Update() {
        if (recorder) TimeSpent += Time.deltaTime;
        else { }
    }
    public void StopRecording (){
        recorder = false;
        print(TimeSpent);
    }
}
