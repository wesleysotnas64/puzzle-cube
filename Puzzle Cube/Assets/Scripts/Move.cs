using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float displacement;
    public float forceJump;
    public Vector3 direction;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) XMove(1);
        if(Input.GetKeyDown(KeyCode.S)) XMove(-1);
        if(Input.GetKeyDown(KeyCode.A)) ZMove(1);
        if(Input.GetKeyDown(KeyCode.D)) ZMove(-1);
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
        direction.Normalize();
        GetComponent<Rigidbody>().AddForce(direction*forceJump, ForceMode.Impulse);
    }
}
