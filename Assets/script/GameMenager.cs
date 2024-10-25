using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    [SerializeField]Transform Cha;
    [SerializeField]Transform Cam;

    [SerializeField] GameObject GameStartPanel, GamePanel;
    bool IsGameStart;

    private void Awake()
    {
        IsGameStart = false;
        Time.timeScale = 0;
    }


    private void FixedUpdate()
    {
        if (Cam && Cha != null)
        {
            GameFinishControl();
        }
        
    }
    private void GameFinishControl()
    {
        if (Cha.position.y <= 1.968f)
        {
            if (Cha.GetComponent<TransformDataController>().enabled && ChangeScore.instance != null)
            {
                ChangeScore.instance.ResetMatColor();

                Cha.GetComponent<TransformDataController>().enabled = false;
                Cha.GetComponent<TransformData>().enabled = false;
                Cha.GetComponent<TransformController>().enabled = false;
                Destroy(Cha.gameObject, 1.35f);
                
                Cam.GetComponent<CameraFollow>().enabled = false;
                Debug.Log(Cha.position.y);
                ScorePrefab();
            }
            
        }
    }

    public void GameStart()
    {
        if (!IsGameStart)
        {
            Time.timeScale = 1;
            GameStartPanel.SetActive(false);
            GamePanel.SetActive(true);
            ++GamedPlayed;
        }  
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(0);
    }


    public void ScorePrefab()
    {
        if (HighScore <= ChangeScore.instance.score)
        {
            HighScore = ChangeScore.instance.score;
            Debug.Log(HighScore);
        }    
    }
    public static int HighScore
    {
        get {
            return PlayerPrefs.GetInt("HighScore");
        }
        set
        {
            PlayerPrefs.SetInt("HighScore", value);
        }
    }

    public static int GamedPlayed
    {
        get
        {
            return PlayerPrefs.GetInt("GamedPlayed");
        }
        set
        {
            PlayerPrefs.SetInt("GamedPlayed", value);
        }
    }

}
