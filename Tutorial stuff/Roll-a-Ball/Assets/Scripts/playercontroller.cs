using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    public float speed; // the public variables will be available in the unity editor

    private Rigidbody rb; // private rigidbody will be a named rigidbody object that can be interacted with

    void Start() // function is called at the start of the first frame
    {
        rb = GetComponent<Rigidbody>(); //creats a rigidbody object in the code by finding a given asset component
    }
    void FixedUpdate() //called before any physics calculations
    {
        float movehorizontal = Input.GetAxis("Horizontal"); //receives input from the corresponding getaxis label in unity preferences
        float movevertical = Input.GetAxis("Vertical");
        Vector3 acceleration = Vector3.zero;
        int i = 0;
        while(i < Input.accelerationEventCount)
        {
            AccelerationEvent accEvent = Input.GetAccelerationEvent(i);
            acceleration += accEvent.acceleration * accEvent.deltaTime;
            ++i;
        }

        float y = 0.0f; // using 'f' changes a double, 0.0, into a literal float?
        Vector3 movement = new Vector3(movehorizontal, y, movevertical); //Vector3 is the class using for vectors in the Unity game engine
        rb.AddForce(movement * speed); // rigidbody objects have a private function, AddForce, which acts on the objects for physics calculations
        rb.AddForce(rb.mass * acceleration * speed);
    }
}
