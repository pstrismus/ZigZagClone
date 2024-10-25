using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStarter : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI GamedPlayed, HighScore;

    private void OnEnable()
    {
        GamedPlayed.text = GameMenager.GamedPlayed.ToString();
        HighScore.text = GameMenager.HighScore.ToString();
    }
}
