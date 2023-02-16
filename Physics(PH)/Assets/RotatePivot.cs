using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePivot : MonoBehaviour
{

    float rotationSpeed = 45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 rotation = transform.localEulerAngles;
            rotation.z -= Time.deltaTime * rotationSpeed;
            transform.localEulerAngles = rotation;
        }

        if(Input.GetKey(KeyCode.S))
        {
            Vector3 rotation = transform.localEulerAngles;
            rotation.z += Time.deltaTime * rotationSpeed;
            transform.localEulerAngles = rotation;
        }
    }
}
