using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechanicalButton : Button {

    bool active;

    GameObject wall;
    GameObject Mech;

    // Use this for initialization
    void Start() {
        active = true;
        wall = GameObject.Find("Mechanical");
        Mech = GameObject.Find("MECH_EXP");
        Mech.SetActive(false);
    }

    public override void onClick() {
        if (active)
        {
            wall.SetActive(false);
            Mech.SetActive(true);
            active = false;
        }
        else
        {
            wall.SetActive(true);
            Mech.SetActive(false);
            active = true;
        }
    }
}
