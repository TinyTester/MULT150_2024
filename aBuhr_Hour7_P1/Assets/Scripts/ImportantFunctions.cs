using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    //Variables
    public int runSpeed;
    //Variables end
    
    // Start is called before the first frame update
    void Start()
    {
        print ("Start runs before an object updates");
    }

    // Update is called once per frame
    void Update()
    {
        print ("This is called once a frame");
    }
}
