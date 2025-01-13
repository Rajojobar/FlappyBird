using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

public TextMeshProUGUI scoreText;

    public int Score;
    bool aCommence;

private void Start()
{
    Time.timeScale = 0f;
}

    public void AddScore(){
        Score++;
        scoreText.text = "Score : " + Score;
        Debug.Log("+1:"+Score);
    }

    public void OnPlayerDie()
    {
        Time.timeScale = 0f;

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