using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject.transform.parent.gameObject);
    }

    void  OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.position = other.transform.position + new Vector3(0, 0.25f, 0);
    }
}
