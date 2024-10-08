using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float displacement;
    public float forceJump;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) XMove(1);
        if(Input.GetKeyDown(KeyCode.S)) XMove(-1);
        if(Input.GetKeyDown(KeyCode.A)) ZMove(1);
        if(Input.GetKeyDown(KeyCode.D)) ZMove(-1);

        if(Input.GetKeyDown(KeyCode.Space)) Jump();
    }

    private void ZMove(int _direction)
    {
        MoveInPlane(new Vector3(0,0,_direction));
    }

    private void XMove(int _direction)
    {
        MoveInPlane(new Vector3(_direction, 0, 0));
    }

    private void MoveInPlane(Vector3 _displace)
    {
        transform.position += _displace;
    }

    private void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up*forceJump, ForceMode.Impulse);
    }
}
