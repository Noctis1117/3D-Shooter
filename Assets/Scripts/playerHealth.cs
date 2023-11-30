using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float health;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("you lose");
        }
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Enemy Bullet")
        {
            health -= 25;
        }
    }
}
