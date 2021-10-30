using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationhandler : MonoBehaviour
{
    public MeshRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        StartCoroutine(Changestate());
    }

IEnumerator Changestate()
    {
        rend.enabled = false;
        yield return new WaitForSecondsRealtime(0.2f);
        rend.enabled = true;
        yield return new WaitForSecondsRealtime(0.2f);
        StartCoroutine(Changestate());
    }
}
