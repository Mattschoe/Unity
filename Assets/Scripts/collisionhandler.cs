using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class collisionhandler : MonoBehaviour
{
    public int deathvalue;
    public AudioSource death1;
    public AudioSource death2;
    public AudioSource death3;
    public AudioSource death4;
    public AudioSource source;
    public Text lose;
    public GameObject ghost1;
    public GameObject ghost2;
    public GameObject ghost3;
    public GameObject ghost4;
    public GameObject playermodel;

    private void Start()
    {
        lose.enabled = false;
        StartCoroutine(StartAI());
        deathvalue = Mathf.FloorToInt(Random.Range(1, 5));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ghost")
        {
            GetComponent<PlayerController>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            ghost1.GetComponent<AI>().enabled = false;
            ghost2.GetComponent<AI>().enabled = false;
            ghost3.GetComponent<AI>().enabled = false;
            ghost4.GetComponent<AI>().enabled = false;
            Destroy(playermodel);
            
            if(deathvalue == 1)
            {
                death1.Play();
            }else if (deathvalue == 2)
            {
                death2.Play();
            }
            else if(deathvalue == 3)
            {
                death3.Play();
            }else
            {
                death4.Play();
            }
            source.Stop();
            lose.enabled = true;
            StartCoroutine(Lose());
        }
    }
    IEnumerator Lose()
    {
        yield return new WaitForSecondsRealtime(4);
        SceneManager.LoadScene(0);
    }
    IEnumerator StartAI()
    {
        yield return new WaitForSecondsRealtime(5);
        ghost3.GetComponent<AI>().enabled = true;
        yield return new WaitForSecondsRealtime(10);
        ghost2.GetComponent<AI>().enabled = true;
        yield return new WaitForSecondsRealtime(20);
        ghost1.GetComponent<AI>().enabled = true;
        yield return new WaitForSecondsRealtime(30);
        ghost4.GetComponent<AI>().enabled = true;
    }
}
