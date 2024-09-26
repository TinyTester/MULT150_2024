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
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        health -= poisionDamage;
        Debug.Log(health);
        Debug.Log("Player has been killed!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
