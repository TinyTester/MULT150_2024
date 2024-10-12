using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    //variables
    bool onSwitch = true;
    Light lightComponent; //Varaible to store the light component
    
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.intensity = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            if(lightComponent.intensity == 0)
                lightComponent.intensity = 1;
            else
                lightComponent.intensity = 0;
            print(lightComponent.intensity);
        }
  
    }
}
