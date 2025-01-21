using UnityEngine;

public class Tuyau_child : MonoBehaviour
{

    public Tuyau tuyauParent;

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