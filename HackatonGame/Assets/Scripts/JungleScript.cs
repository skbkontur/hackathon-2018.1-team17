﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JungleScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.name.Contains("rhino"))
        {
            theCollision.gameObject.GetComponentInParent<SpeedRinoParent>().enabled = false;
            theCollision.gameObject.GetComponent<PlayerController>().ShowWin();
        }
    }
}
