using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : PowerUp {
    
    public int value;
    // Use this for initialization
    void Start () {
        timer = .5f;
        value = 10;
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    public override void Functionality()
    {
        player.health += value;
    }


    public override void Reset()
    {
        // no reset
    }
}
