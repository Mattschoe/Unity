using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.eulerAngles = new Vector3(0,180,0);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            transform.localScale = new Vector3(1, 1, 1);
        } 
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.S))
        {
            Rb.AddRelativeForce(0, 0, 10);
        }
    }
}
