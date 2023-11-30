using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float health;
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player Bullet")
        {
            health -= 50;
        }
    }
}
