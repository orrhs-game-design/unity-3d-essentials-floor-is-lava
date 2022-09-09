using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchController : MonoBehaviour
{
    public bool raiseRight = true;

    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rock the arch up and down 1 degree per second until it reaches 185 degrees or 210 degrees
        if (raiseRight)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * speed);
         
        }
        else
        {
            transform.Rotate(Vector3.back * Time.deltaTime * speed);
        }
        
        if (transform.rotation.eulerAngles.z < 170)
        {
            raiseRight = true;
        }
        if (transform.rotation.eulerAngles.z > 220)
        {
            raiseRight = false;
        }
    }
}
