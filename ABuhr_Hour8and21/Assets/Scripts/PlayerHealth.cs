using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Variables
    int healthpoints = 3992;

    //Methods
    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
    
    //
    //stuff that actually runs
    //
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start: " + healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log("end: " + healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
