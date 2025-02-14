using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverPanel;
    public AudioSource audio;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }
    void Start()
    {
        audio.Play();
    }
    public void ResetScore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver() {
        gameOverPanel.SetActive(true);
    }
}
