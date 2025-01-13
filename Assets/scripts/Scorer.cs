using UnityEngine;

public class Scorer : MonoBehaviour
{

    GameManager Game;

    private void Start(){
        Game = FindObjectOfType<GameManager>();

    }

    private void OnTriggerEnter2D(Collider2D collision){
        Joueur _joueur = collision.gameObject.GetComponent<Joueur>();
        if (_joueur){
            Debug.Log("+1");
            Game.AddScore();
        }
    }
}