using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public Text scoreText;
    // Update is called once per frame

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreText.text = score.ToString();
    }
    public void Add()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
