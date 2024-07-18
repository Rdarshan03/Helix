using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMove : MonoBehaviour
{
    
    float Rotationspeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {   
            var mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(transform.position.x, -mouseX * Rotationspeed * Time.deltaTime, transform.position.z);
        }
    }
    

}
