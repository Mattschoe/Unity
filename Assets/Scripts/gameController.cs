using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public bool ispaused;
    public GameObject ghost1;
    public GameObject ghost2;
    public GameObject ghost3;
    public GameObject ghost4;
    public GameObject Player;
    public Text win;
    public Text score;
    public Text pause;
    public Button quit;
    public Text quittext;
    public Image img;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        win.enabled = false;
        score.enabled = true;
        ispaused = false;
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
        if (Input.GetKeyDown(KeyCode.Escape) && ispaused == false)
        {
            Player.GetComponent<PlayerController>().enabled = false;
            source.Stop();
            ispaused = true;
            Time.timeScale = 0f;
            score.enabled = false;
            pause.enabled = true;
            quit.enabled = true;
            quittext.enabled = true;
            img.enabled = true;
        }else if (Input.GetKeyDown(KeyCode.Escape) && ispaused == true)
        {
            Player.GetComponent<PlayerController>().enabled = true;
            ispaused = false;
            Time.timeScale = 1f;
            score.enabled = true;
            pause.enabled = false;
            quit.enabled = false;
            quittext.enabled = false;
            img.enabled = false;
        }
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator WinProcess()
    {
        
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(0);

    }
}
