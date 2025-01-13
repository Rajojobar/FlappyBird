using UnityEngine;

public class Tuyau : MonoBehaviour
{

    public float Speed;
    public float deadZone = -11f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Joueur _joueur = collision.gameObject.GetComponent<Joueur>();
        if(_joueur != null)
        {
            _joueur.gameObject.SetActive(false);
            FindObjectOfType<GameManager>().killPlayer();

        }
    }

    void Update(){
        transform.position += new Vector3(Speed * Time.deltaTime, 0f);
        if (transform.position.x < deadZone){
            Destroy(gameObject);
        }

    }
}