using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class charhacter : MonoBehaviour
{
    [SerializeField]GameObject GameOverUI, GameUI;
    private void OnDestroy()
    {
        GameUI.SetActive(false);
        GameOverUI.SetActive(true);
        Time.timeScale = 0;

    }
}
