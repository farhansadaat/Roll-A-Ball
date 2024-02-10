using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SOURCE: https://www.youtube.com/watch?v=Mic9ERhr0HA

public class Respawn : MonoBehaviour
{
    public float threshold;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y < threshold) {
            transform.position = new Vector3(0.41f, 2.32f, 0.005f);
        }
    }
}
