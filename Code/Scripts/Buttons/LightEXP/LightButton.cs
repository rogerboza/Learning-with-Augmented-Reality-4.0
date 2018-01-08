using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : Button {

	// Use this for initialization

    public override void onClick()
    {
        InfoPanel.setTextPanel("LIGHT_INTRO");
        LeftController.instance.infoPanel.enableExitButton();
        GameObject.Find("OVRCameraRig").transform.position = new Vector3(-55f, 60f, 40f);
        LeftController.instance.optionPanel.setOptionPanel("LightOptions");
    }
}
