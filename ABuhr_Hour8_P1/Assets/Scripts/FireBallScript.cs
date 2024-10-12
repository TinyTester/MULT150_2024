using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Methods 
    int TakeDamageFromFireball(){
        int playerHealth = 100;
        return playerHealth - 5;
    }

    int TakeDamageFromFireball(int damage){
        int playerHealth = 100;
        return playerHealth - damage;

    }
    
    int TakeDamageFromFireball(int damage, int playerHealth){
        return playerHealth - damage;
    }
    
    /// <summary>
    /// YAHHHHHHHHHHHHHHHHOOOOOOOOOOOOOOOOOOOOOOOOOOOO I just needed something to break up the code for readability
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        print ("Player health (from 1): " + x);

        int y = TakeDamageFromFireball(25);
        print ("Player health (from 2): " + y);
        
        int z = TakeDamageFromFireball(30, 50);
        print ("Player health (from 3): " + z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
