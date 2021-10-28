using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpHandler : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject top;
    public GameObject bottom;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Top")
        {
            transform.position = new Vector3(bottom.transform.position.x, bottom.transform.position.y, bottom.transform.position.z);
        }
        if (other.tag == "Bottom")
        {
            transform.position = new Vector3(top.transform.position.x, top.transform.position.y, top.transform.position.z);
        }
        if (other.tag == "Left")
        {
            transform.position = new Vector3(right.transform.position.x, right.transform.position.y, right.transform.position.z);
        }
        if (other.tag == "Right")
        {
            transform.position = new Vector3(left.transform.position.x, left.transform.position.y, left.transform.position.z);
        }
    }
}
