using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attention : MonoBehaviour {
	public GameObject cube;
    public GameObject HP;
	// Use this for initialization
	float accelerometerUpdateInterval = 1.0f / 60.0f;
	// The greater the value of LowPassKernelWidthInSeconds, the slower the
	// filtered value will converge towards current input sample (and vice versa).
	float lowPassKernelWidthInSeconds = 2.0f;
	// This next parameter is initialized to 2.0 per Apple's recommendation,
	// or at least according to Brady! ;)
	float shakeDetectionThreshold = 5.0f;

	Vector3 i;
	float lowPassFilterFactor;
	Vector3 lowPassValue;
    //coutdowntimer
    public bool activation = false;
	// Use this for initialization
	void Start () {
		lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
		shakeDetectionThreshold *= shakeDetectionThreshold;
		lowPassValue = GvrControllerInput.Gyro;
		i = new Vector3(4, 4, 4);
		print(i.sqrMagnitude);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 acceleration = GvrControllerInput.Gyro;
		lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
		Vector3 deltaAcceleration = acceleration - lowPassValue;
		if (activation) {
            HP.SetActive(false);
			cube.SetActive (true);
			if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold) {
                SoundManagerScript.PlaySound("correct");
				cube.SetActive (false);
                activation = false;
                HP.SetActive(true);
            }
		}

	}
}
