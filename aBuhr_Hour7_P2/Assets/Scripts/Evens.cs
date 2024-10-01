using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /// I have less experience with the Modulus operator 
        /// so I'm gonna try and make a script using it
        /// 
        int num = 22;

        for (int i = 0; num <= 100; i++)
        {
            num += 1;
            if (num % 2 <= 0)
            {
                print(num);
            }
        }
    }
}
