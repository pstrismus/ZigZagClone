using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChangeScore : MonoBehaviour
{
    TextMeshProUGUI ScoreUI;
    public int score = 0;

    [SerializeField]Color[] color;
    [SerializeField] Material Mat;
    int scoree = 49;
    public static ChangeScore instance;

    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        ScoreUI = GetComponent<TextMeshProUGUI>();
        ScoreUI.text = score.ToString();

    }

    public void ChangeScor(int puan)
    {
        score += puan;
        ScoreUI.text = score.ToString();
    }

    private void PathColorChange()
    {
        int ColorVote = Random.Range(0, color.Length);
        if (Mat.color != color[ColorVote])
        {
            Mat.color = color[ColorVote];   

        }
        else if (Mat.color == color[ColorVote])
        {
            PathColorChange();
        }
    }

    public void PathColorChangeControl()
    {
        if (score - scoree == 0)
        {
            PathColorChange();
            scoree += 49;
        }  
    }
    public void ResetMatColor()
    {
        Mat.color = color[0];
    }
}
