using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

public TextMeshProUGUI scoreText;

    public int Score;

    public void AddScore(){
        Score++;
        scoreText.text = "Score : " + Score;
        Debug.Log("+1:"+Score);
    }

}