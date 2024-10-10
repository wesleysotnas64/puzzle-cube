using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LotusFlower : MonoBehaviour
{
    public bool activeSineEffect;
    public bool activeRotateEffect;
    public float speedRotation;
    public float amplitude = 1f;
    public float frequency = 1f;
    private Vector3 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
       startPosition = transform.position;
    }

    void Update()
    {
        if(activeRotateEffect) RotateEffect();
        if(activeSineEffect) SineMovementEffect();
    }

    private void RotateEffect()
    {
        transform.Rotate(new Vector3(0, speedRotation, 0) * Time.deltaTime);
    }

    private void SineMovementEffect()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
