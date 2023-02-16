using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeftArm : MonoBehaviour
{
    private float minDegree = -5.0f;
    private float maxDegree = 180.0f;
    private float x = 0.0f;
    float rotationSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && x < maxDegree){
            transform.RotateAround(transform.parent.position, new Vector3(0, 0, -1), rotationSpeed * Time.deltaTime);
            x += rotationSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.F) && x > minDegree){
            transform.RotateAround(transform.parent.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
            x -= rotationSpeed * Time.deltaTime;
        }
    }
}
