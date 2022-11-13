using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(6 * Time.deltaTime, 0, 0);
        if(transform.position.x <= -17.77)
        {
            transform.position = new Vector3 (17.77f, transform.position.y, 0f);
        }
    }
}
