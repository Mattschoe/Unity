using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource sound;
    public float Speed = 20f;
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
            transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
        } 
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
            transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.S))
        {
            Rb.AddRelativeForce(0, 0, Speed*Time.deltaTime);
        }
        if (Rb.velocity.magnitude > 0 && sound.isPlaying == false)
        {
            sound.Play();
        }
        else if(Rb.velocity.magnitude <=0 && sound.isPlaying == true)
        {
            sound.Stop();
        }
    }
}
