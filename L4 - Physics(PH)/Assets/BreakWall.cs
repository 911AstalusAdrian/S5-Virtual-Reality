using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{

    int hitpoints;

    // Start is called before the first frame update
    void Start()
    {
        hitpoints = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Projectile") {
            hitpoints -= 1;
        }

        if(hitpoints == 0){
            gameObject.SetActive(false);
        }
    }
}
