using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : Button {

    static Vector3 originalPosition;

	// Use this for initialization

	public override void onClick()
    {
        GameObject.Find("OVRCameraRig").transform.position = originalPosition;
        InfoPanel.setTextPanel("SIPA_INTRO");
        LeftController.instance.optionPanel.disableOptionPanel();
        this.gameObject.SetActive(false);
    }

    public void setOriginalPosition(Vector3 position)
    {
        originalPosition = position;
    }
}
