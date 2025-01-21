using UnityEngine;

public class Tuyau : MonoBehaviour
{

    public float Speed;
    public float deadZone = -11f;


    void Start()
    {
        float randomY = Random.Range(-1.5f, 1.5f);

        Vector3 newPosition = transform.position;
        newPosition.y += randomY;
        transform.position = newPosition;
    }

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