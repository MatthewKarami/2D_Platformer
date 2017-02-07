using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : PowerUp {
    
    public int value;

    void Start ()
    {
        timer = .5f;
        value = 10;
	}
	
	void Update ()
    {
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
