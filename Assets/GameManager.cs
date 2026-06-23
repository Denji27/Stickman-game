using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     public static GameManager instance;

    public TMP_Text scoreText;
    public GameObject gameOverPanel;
    public CanvasGroup gameOverCanvasGroup;

    private int score = 0;
    private bool isGameOver = false;
    public float fadeSpeed = 2f;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        InvokeRepeating(nameof(AddScore), 1f, 1f);
    }

    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

        if (isGameOver)
        {
            if (gameOverCanvasGroup.alpha < 1)
            {
                gameOverCanvasGroup.alpha += fadeSpeed * Time.unscaledDeltaTime;
            }
        }
    }

    void AddScore()
    {
        if (isGameOver)
            return;

        score++;
        scoreText.text = "Score: " + score;
    }

    // public void GameOver()
    // {
    //     isGameOver = true;

    //     gameOverText.SetActive(true);

    //     Time.timeScale = 0f;
    // }

    public void GameOver()
    {
    isGameOver = true;

    Debug.Log("Game over " + isGameOver);

    gameOverCanvasGroup.alpha = 0;

    Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
