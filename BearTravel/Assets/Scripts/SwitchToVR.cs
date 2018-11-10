using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.VR;

public class SwitchToVR : MonoBehaviour {

	// Use this for initialization
	public void Start () {
        StartCoroutine(SwitchVR());
    }
   public IEnumerator SwitchVR()
    {
        string[] DaydreamDevices = new string[] { "daydream", "cardboard" };
        XRSettings.LoadDeviceByName(DaydreamDevices);

        // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
        yield return null;

        // Now it's ok to enable VR mode.
        XRSettings.enabled = true;
    }

    // Update is called once per frame

}
