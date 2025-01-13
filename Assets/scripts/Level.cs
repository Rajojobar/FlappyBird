using UnityEngine;

public class Level : MonoBehaviour
{
    public float Speed;
    public Vector3 initPosition;
    public float deadZone;
    
    void Start()
    {
        initPosition=transform.position;
    }

    void Update(){
        transform.position += new Vector3(Speed * Time.deltaTime, 0f);
        if (transform.position.x < deadZone){
            transform.position = initPosition;
        }

    }
}