using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_TriggerScript : MonoBehaviour
{
    
    void OnTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " has enetered " + gameObject.name);
    }
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in " + gameObject.name);
    }
    void OnTriggerExit (Collider other)
    {
        print(other.gameObject.name + " has left " + gameObject.name);
    }
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
