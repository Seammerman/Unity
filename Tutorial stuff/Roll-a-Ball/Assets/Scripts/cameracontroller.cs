using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour {
    public GameObject player; // public allows the GameObject to be specified in the Unity editor
    private Vector3 offset; // offset is to be calculated based on starting positions, thus it is private and is only available in the script
	
	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () //called after everything in Update() has already been ran
    {
        transform.position = player.transform.position + offset;
	}
}
