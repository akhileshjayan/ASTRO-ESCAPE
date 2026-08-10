using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [Header("Pipe Settings")]    
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2f;

    private float timer;

    void Start()
    {
        SpawnPipe();
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }


  void SpawnPipe()
  {
    if (pipePrefab == null)
    {
      Debug.LogWarning("SpawnScript: pipePrefab is missing. Assign a prefab in the inspector.");
      return;
    }

    float randomY = Random.Range(-heightOffset, heightOffset);

    Instantiate(pipePrefab,
     new Vector3(transform.position.x, randomY, 0),
      Quaternion.identity);
  }
}

