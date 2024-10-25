using UnityEngine;
using TMPro;
public class GameOverUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Score, HighScore;

    private void OnEnable()
    {
        Score.text = ChangeScore.instance.score.ToString();
        HighScore.text = GameMenager.HighScore.ToString();
    }
}
