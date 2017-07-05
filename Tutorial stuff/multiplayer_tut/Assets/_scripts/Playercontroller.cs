using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float walkspeed = 3.0f;
    public float turnspeed = 150.0f;
 

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * turnspeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkspeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        
    }

}