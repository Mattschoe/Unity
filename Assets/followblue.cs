using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followblue : MonoBehaviour
{
    public GameObject blue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = blue.transform.position + new Vector3(0,0,0.3f);
    }
}
