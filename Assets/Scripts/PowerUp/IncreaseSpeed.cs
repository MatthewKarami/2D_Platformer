using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : PowerUp {

    public float value;

    public void Start()
    {
        timer = 3f;
        value = 2;
    }
	
    public void Update ()
    {
        base.Update();
    }

    public override void Functionality()
    {
        player.moveSpeed *= value;
    }

    public override void Reset()
    {
        player.moveSpeed /= value;
    }
}
