using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour {

    public float timer { get; set; }
    public bool isUsed { get; set; }
    public PlayerController player;

    public void Start()
    {
        isUsed = false;
    }

    public void Update()
    {
        if (isUsed)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            if (timer <= 0)
            {
                this.Reset();
                Destroy(this.gameObject);
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isUsed && collision.gameObject.name == "Player_1")
        {
            this.Functionality();
            isUsed = true;
        }
    }

    public abstract void Functionality();
    public abstract void Reset();
}
