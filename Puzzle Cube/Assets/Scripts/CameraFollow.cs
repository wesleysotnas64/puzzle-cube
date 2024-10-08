using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float speed;
    private Transform playerTransform;
    
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    
    void Update()
    {
        Follow();
    }

    private void Follow()
    {
        float magnitude = (playerTransform.position - transform.position).magnitude;

        if(magnitude > 0.01f)
            transform.position = Vector3.Lerp(transform.position, playerTransform.position, Time.deltaTime * speed);
    }
}
