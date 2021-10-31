using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AI : MonoBehaviour
{
    public NavMeshAgent navmeshagent;
    public GameObject Player;
    // Start is called before the first frame update
    public void OnValidate()
    {
       navmeshagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navmeshagent.destination = Player.transform.position;
    }
}
