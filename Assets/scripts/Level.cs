using UnityEngine;

public class Level : MonoBehaviour
{

    public GameObject tuyauPrefab;
    public GameObject tuyauSpawnGO;
    


    [ContextMenu("Spawn un tuyau")]
    public void SpawnTuyau()
    {
        Instantiate(tuyauPrefab, tuyauSpawnGO.transform);
    }


    void Start(){
        InvokeRepeating("SpawnTuyau", 1f, 1f);  //1s delay, repeat every 1s
        SpawnTuyau();
    }
}