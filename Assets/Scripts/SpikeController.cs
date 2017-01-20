using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpikeController : MonoBehaviour {

    // public GameObject player;
    public GameObject GUI;
    public Text health;

    private int healthVal;
    private const int totalHealth = 100;

	void Start () {
        health = GUI.GetComponent<Text>();
        healthVal = totalHealth;
	}
	
	void Update () {
        health.text = "Health: " + healthVal;

        //if (healthVal <= 0)
        //{
        //    Destroy(player.gameObject);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            healthVal -= totalHealth;
            //Destroy(player.gameObject);
        }
    }
}
