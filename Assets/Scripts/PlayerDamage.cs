using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour {

    public GameObject UI;
    public Text health;
    public float damageBump;

    private int healthVal;
    private const int totalHealth = 100;

    void Start()
    {
        healthVal = totalHealth;
        health = UI.GetComponent<Text>();
        UpdateHealth();
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            healthVal -= totalHealth;
            UpdateHealth();
            CheckIfDead();
        }

        if (collision.gameObject.tag == "HexagonEnemy")
        {
            healthVal -= totalHealth / 2;
            UpdateHealth();
            CheckIfDead();
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, damageBump));
        }
    }

    private void UpdateHealth()
    {
        health.text = "Health: " + healthVal;
    }

    // Only needs to be preformed after damage is taken.
    private void CheckIfDead()
    {
        if (healthVal <= 0)
        {
            Destroy(gameObject);
        }
    }
}

