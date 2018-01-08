using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LeftController : MonoBehaviour
{

    public OVRInput.Controller controller = OVRInput.Controller.LTouch;
    GameObject camera;

    public OptionPanel optionPanel;
    public MapPanel mapPanel;
    public InfoPanel infoPanel;

    public static LeftController instance;

    private void Start()
    {
        instance = this;
        optionPanel = GameObject.Find("OptionsPane").GetComponent<OptionPanel>();
        mapPanel = GameObject.Find("MapPane").GetComponent<MapPanel>();
        infoPanel = GameObject.Find("InfoPane").GetComponent<InfoPanel>();
        camera = GameObject.Find("OVRCameraRig");
    }
    private void Update()
    {
        transform.localPosition = OVRInput.GetLocalControllerPosition(controller); ;
        transform.localRotation = OVRInput.GetLocalControllerRotation(controller);

        Vector2 joy = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, controller);
        transform.GetChild(0).transform.Rotate(new Vector3(joy.y * 3, 0, 0));
    }
}

