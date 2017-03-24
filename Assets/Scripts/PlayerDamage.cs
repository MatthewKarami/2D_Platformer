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

    public void Start()
    {
        healthVal = totalHealth;
        health = UI.GetComponent<Text>();
        UpdateHealthText();
    }

    public void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            healthVal -= totalHealth;
            UpdateHealthText();
            CheckIfDead();
        }
        if (collision.gameObject.tag == "HexagonEnemy" || collision.gameObject.tag == "RectangleEnemy")
        {
            // Only take damage if the enemy is not killed
            Vector2 v = transform.position - (Vector3)collision.contacts[0].point;
            if (Mathf.Abs(Vector2.Angle(v, Vector2.up)) > 45.0)
            {
                healthVal -= totalHealth / 2;
                UpdateHealthText();
                CheckIfDead();
            }
            // Bumps player away from enemy
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, damageBump));
        }
    }

    public void AddHealth(int howMuch)
    {
        healthVal += howMuch;
        UpdateHealthText();
    }

    private void UpdateHealthText()
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

