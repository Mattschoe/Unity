using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public GameObject ghost1;
    public GameObject ghost2;
    public GameObject ghost3;
    public GameObject ghost4;
    public GameObject Player;
    public Text win;
    public Text score;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        win.enabled = false;
        score.enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
            GameObject[] food = GameObject.FindGameObjectsWithTag("Food");
        score.text = "Score: " +((food.Length - 198) * -1).ToString() + " / 198";
        if(food.Length <= 0)
        {
            source.Stop();
            ghost1.GetComponent<AI>().enabled = false;
            ghost2.GetComponent<AI>().enabled = false;
            ghost3.GetComponent<AI>().enabled = false;
            ghost4.GetComponent<AI>().enabled = false;
            Player.GetComponent<PlayerController>().enabled = false;
            score.enabled = false;
            win.enabled = true;
            StartCoroutine(WinProcess());
        }
    }

    IEnumerator WinProcess()
    {
        
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(0);

    }
}
