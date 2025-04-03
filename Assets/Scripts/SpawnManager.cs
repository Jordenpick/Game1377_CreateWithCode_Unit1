using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    [SerializeField]
    private Transform[] spawnTransform;

    [SerializeField]
    private float spawnTimer = 0;

    [SerializeField]
    private float spawnCoolDown = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnRandomVechicle();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnCoolDown)
        {
            spawnTimer = 0;
            SpawnRandomVechicle();
        }
    }

    private void SpawnRandomVechicle()
    {
        int spawnTransformIndex = Random.Range(0, spawnTransform.Length);
        Transform currentSpawnTransform = spawnTransform[spawnTransformIndex];
        Instantiate(spawnPrefab, currentSpawnTransform.position, currentSpawnTransform.rotation);
    }
}
