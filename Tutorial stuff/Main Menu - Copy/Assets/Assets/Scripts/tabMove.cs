using UnityEngine;

public class tabMove : MonoBehaviour {
    private bool clicked = false;
    public void Start()
    {
        if (clicked == true)
        {
            transform.Translate(-551.375f, 0, 0);
            clicked = false;
        }
        else
        {
            transform.Translate(551.375f, 0, 0);
            clicked = true;
        }
    }
}
