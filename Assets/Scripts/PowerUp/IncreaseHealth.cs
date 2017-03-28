using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : PowerUp {
    
    public int value;
    public int max;
    private int total;

    public void Start ()
    {
        timer = 10f;
    }

    public void Update ()
    {
        base.Update();
        if (total >= max) SetIsFinished(true);
    }

    public override void Functionality()
    {
        total += value;
        if(total <= max)
        {
            player.GetComponent<PlayerDamage>().AddHealth(value);
        }
       
    }


    public override void Reset()
    {
        // no reset
    }

}
