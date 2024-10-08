using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject.transform.parent.gameObject);
    }

    // void  OnTriggerEnter(Collider other)
    // {
    //     Destroy(other.gameObject);
    // }
}
