using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 5f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 69;
    [SerializeField] int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;



    // Start is called before the first frame update
    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;

    }

    //Git Try 123

    public void AddScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();

    }

}
