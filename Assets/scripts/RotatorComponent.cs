using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorComponent : MonoBehaviour
{
    // The axis around which the gameObject is rotating
    [SerializeField ]
   private Vector3 rotationAxis = Vector3.up;
    //The speed with which the gameObject is rotation. Measured in degrees/frame
   private float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);   
    }
}
