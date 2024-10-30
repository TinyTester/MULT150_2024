using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeloctyScript : MonoBehaviour
{
   public float startSpeed = 50f;
   // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody> ();
        rigidBody.velocity = new Vector3 (startSpeed, 0, startSpeed);
    }
}
