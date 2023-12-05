using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public static int healthTotal = 100;

    public Text healthText;

    void Start()
    {
        healthTotal = 100;
    }


    

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + healthTotal;

        if (healthTotal <= 0)
        {
            Debug.Log("you lose");
        }

    }
}
