using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Variables
        float health = 1004f;
        float poisionDamage = 125.5f;

        //actual code
        while (health > 0)
        {
            Debug.Log(health);
            health -= poisionDamage;
        }
        if (health <= 0)
        { 
            Debug.Log("Player has been killed!"); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
