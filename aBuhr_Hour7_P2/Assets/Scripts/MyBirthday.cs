using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int day = 1; day <= 29; day++)
        {
            if (day == 13)
            {
                print("It's my birthday! :D");
            }
            else 
            {
                print(day);
            }
        }
    }

}
