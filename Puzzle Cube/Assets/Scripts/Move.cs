using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool jumpEnabled;
    public float forceJump;
    public Vector3 direction;

    void Start()
    {
        jumpEnabled = false;
    }

    
    void Update()
    {
        if(jumpEnabled)
        {
            if(Input.GetKeyDown(KeyCode.E)) XMove(1);
            if(Input.GetKeyDown(KeyCode.S)) XMove(-1);
            if(Input.GetKeyDown(KeyCode.W)) ZMove(1);
            if(Input.GetKeyDown(KeyCode.D)) ZMove(-1);
        }
    }


    private void ZMove(int _direction)
    {
        direction = new Vector3(0, 1, 0.75f*_direction);
        Jump();
    }

    private void XMove(int _direction)
    {
        direction = new Vector3(0.75f*_direction, 1, 0);
        Jump();
    }

    private void Jump()
    {
        jumpEnabled = false;
        direction.Normalize();
        GetComponent<Rigidbody>().AddForce(direction*forceJump, ForceMode.Impulse);
    }
}
