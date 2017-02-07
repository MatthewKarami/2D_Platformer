using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {
    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -8)
        {
            player.transform.position = this.transform.position;
        }
    }
}
