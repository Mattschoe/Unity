using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public Text win;
    public Text score;
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
            score.enabled = false;
            win.enabled = true;
            StartCoroutine(WinProcess());
        }
    }

    IEnumerator WinProcess()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(0);

    }
}
