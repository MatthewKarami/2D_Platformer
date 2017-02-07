using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : PowerUp {
    
    public int value;

    public void Start ()
    {
        timer = .5f;
        value = 10;
	}

    public void Update ()
    {
        base.Update();
	}

    public override void Functionality()
    {
        player.GetComponent<PlayerDamage>().AddHealth(value);
    }


    public override void Reset()
    {
        // no reset
    }

}
