using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    [SerializeField]
    private Transform[] spawnTransform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int spawnTransformIndex = Random.Range(0, spawnTransform.Length);
        Transform currentSpawnTransform = spawnTransform[spawnTransformIndex];
        Instantiate(spawnPrefab, currentSpawnTransform.position, currentSpawnTransform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
