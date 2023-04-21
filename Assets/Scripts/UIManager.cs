using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject panelLC;
    [SerializeField] private GameObject score;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text lastScoreText;

    public static UIManager instance;
   

    private void Awake()
    {
        instance = this;
    }

    public void SetScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void SetLastScore(int lastScore)
    {
        lastScoreText.text = lastScore.ToString();
    }


    public void ActiveLC()
    {
        panelLC.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void DeActiveScore()
    {
        score.SetActive(false);
    }
    public void ActiveLevelComplete()
    {
        panelLC.SetActive(true);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
