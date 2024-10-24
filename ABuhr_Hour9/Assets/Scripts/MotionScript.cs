using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Horizontal") / 50;
        float Y = Input.GetAxis("Vertical") / 50;
        transform.Translate(X, Y, 0);
    }
}
