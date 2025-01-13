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

}