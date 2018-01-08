using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_SoilProfile : Button {

	// Use this for initialization
	void Start () {
		
	}
	void Update() {
		this.transform.LookAt (GameObject.Find ("OVRCameraRig").transform.position);
	}
    public override void onClick()
    {
        InfoPanel.setTextPanel("SOIL_INTRO");
        LeftController.instance.infoPanel.enableExitButton();
        GameObject.Find("OVRCameraRig").transform.position = new Vector3(631f, 100f, 359f);
        GameObject.Find("Soil Animation - 120516").GetComponent<Animation>().Rewind();
        GameObject.Find("Soil Animation - 120516").GetComponent<Animation>().Play();
    }
}
