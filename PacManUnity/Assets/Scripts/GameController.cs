using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController Instance;

    void Awake()
    {
        Instance = this;
    }

    private int mScore;

    [SerializeField] private Text txtScore;
    [SerializeField] private GameObject txtOver;
    [SerializeField] private GameObject txtWin;
    [SerializeField] private GameObject pacParent;
    [SerializeField] private GameObject imgQuit;

    public int Score
    {
        get { return mScore;}
        set
        {
            mScore = value;
            txtScore.text = mScore.ToString();
            Invoke("HasWin", 0.1f);
            Invoke("HasWin", 2f);
        }
    }

    public void GameOver()
    {
        txtOver.gameObject.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void HasWin()
    {
        if (pacParent.transform.childCount == 0)
        {
            txtWin.SetActive(true);
        }   
    }

    public void ShowQuit(bool show)
    {
        imgQuit.SetActive(show);
        if (show)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
