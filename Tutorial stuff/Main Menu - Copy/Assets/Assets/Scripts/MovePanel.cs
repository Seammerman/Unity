using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanel : MonoBehaviour {
    public float fps = 30.0f;
    public float movetime = 1.0f;

    public GameObject RefPanel;
    public GameObject TargetPanel;

    private Vector3 velocity;
    private Vector3 startpos;
    private Vector3 endpos;
    private Vector3 delpos;
    private bool clicked = false;
    // Use this for initialization
    private void Start()
    {
        startpos = TargetPanel.transform.position;
        endpos = RefPanel.transform.position;
        velocity = (endpos - startpos) / (fps * movetime);

    }
    public void click () {
        clicked = true;
    if (TargetPanel.transform.position != startpos)
            {
                TargetPanel.transform.position = startpos;
            }
    else if(TargetPanel.transform.position != endpos)
        {
            TargetPanel.transform.position = endpos;
        }
    }
    private void Update()
    {
        if (GetComponent(Button) == false)
        {
            TargetPanel.transform.position = startpos;
        }
        else
        {
            return;
        }
    }
}
