using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRightArm : MonoBehaviour
{
    private float minDegree = -5.0f;
    private float maxDegree = 150.0f;
    private float x = 0.0f;
    float rotationSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.C) && x < maxDegree){
            transform.RotateAround(transform.parent.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
            x += rotationSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.V) && x > minDegree){
            transform.RotateAround(transform.parent.position, new Vector3(0, 0, -1), rotationSpeed * Time.deltaTime);
            x -= rotationSpeed * Time.deltaTime;
        }
    }
}
