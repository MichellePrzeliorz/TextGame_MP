using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int shoot = 500;

    // Program zgaduje nasza liczbe, ktora sobie wymyslilismy z konkretnego przedzialu
    void Start()
    {
       
        Debug.Log("Welcome to the game! Think about a number from 1 to 1000");
        Debug.Log("Is your number equal/greater/less than 500?");
        //print string
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Is your number equal/greater/less than" + shoot + " ?");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Is your number equal/greater/less than" + shoot + " ?");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Got it!");
        }
    }
}
