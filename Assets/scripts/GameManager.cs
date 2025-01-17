using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

public TextMeshProUGUI scoreText;

    public int Score;
    bool aCommence;

    public CanvasGroup ingameMenu;
    public CanvasGroup gameOverMenu;
    public Button restartButton;
    
    private void Start()
    {
        Time.timeScale = 0f;
        gameOverMenu.gameObject.SetActive(false);
        restartButton.onClick.AddListener( () => restartGame());
    }

    public void AddScore(){
        Score++;
        scoreText.text = "Score : " + Score;
        Debug.Log("+1:"+Score);
    }

    void registerScore(){
        int _currentBest = PlayerPrefs.GetInt("best_score");
        if (Score > _currentBest){
            PlayerPrefs.SetInt("best_score", Score);
        }
    }

    void restartGame(){
            SceneManager.LoadScene("SampleScene");
    }

    public void OnPlayerDie()
    {
        Time.timeScale = 0f;
        registerScore();
        scoreText.text = "You died and meilleur score est "+PlayerPrefs.GetInt("best_score");
        gameOverMenu.gameObject.SetActive(true);
    }

    public void killPlayer(){

        OnPlayerDie();
    }
    
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene("SampleScene");
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Time.timeScale = 1f;
        }
    }
}