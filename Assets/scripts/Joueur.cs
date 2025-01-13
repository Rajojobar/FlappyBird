using UnityEngine;

public class Joueur : MonoBehaviour
{

    Rigidbody2D Rigidbody;
    bool isJumping;
    public float forceSaut;

    void Start(){
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if(isJumping)
        {
            Rigidbody.linearVelocity = Vector2.zero;
            Rigidbody.AddForce(new Vector2(0f, forceSaut));
            isJumping = false;
        }
    }
 

}