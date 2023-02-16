using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLauncher : MonoBehaviour
{
    float rotationSpeed = 45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Vector3 rotation = transform.localEulerAngles;
            rotation.y -= Time.deltaTime * rotationSpeed;
            transform.localEulerAngles = rotation;
        }

        if(Input.GetKey(KeyCode.D))
        {
            Vector3 rotation = transform.localEulerAngles;
            rotation.y += Time.deltaTime * rotationSpeed;
            transform.localEulerAngles = rotation;
        }
    }
}
