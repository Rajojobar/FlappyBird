using UnityEngine;

public class Tuyau : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Joueur _joueur = collision.gameObject.GetComponent<Joueur>();
        if(_joueur != null)
        {
            _joueur.gameObject.SetActive(false);
            FindObjectOfType<GameManager>().killPlayer();

        }
    }
}