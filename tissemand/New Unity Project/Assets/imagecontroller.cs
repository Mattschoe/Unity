using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            transform.localScale = new Vector3(0.25f, 1, 0.25f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            transform.localScale = new Vector3(0.25f, 1, 0.25f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
    
            transform.localScale = new Vector3(0.25f, 1, -0.25f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           
            transform.localScale = new Vector3(0.25f, 1, 0.25f);
        }
    }
}
