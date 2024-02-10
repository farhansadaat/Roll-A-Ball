using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour
{
    public GameObject door;
    public int count;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
            
    }

    void SetActive() {
        if (count == 1) {
                door.SetActive(false);
            }
    }

}