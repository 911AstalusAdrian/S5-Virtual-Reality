using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeftForearm : MonoBehaviour
{
    private float minDegree = -5.0f;
    private float maxDegree = 120.0f;
    private float x = 0.0f;
    float rotationSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) && x < maxDegree){
            transform.RotateAround(transform.parent.position, new Vector3(-1, 0, 0), rotationSpeed * Time.deltaTime);
            x += rotationSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S) && x > minDegree){
            transform.RotateAround(transform.parent.position, new Vector3(1, 0, 0), rotationSpeed * Time.deltaTime);
            x -= rotationSpeed * Time.deltaTime;
        }
    }
}
