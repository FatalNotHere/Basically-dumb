using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{ 
  public GameObject obstaclePrefab;
  public Transform player;
  public float spawnInterval = 2f;
  private float timeUntilSpawn;

  void Start()
  {
        timeUntilSpawn = spawnInterval;
  }
  
  void Update()
  {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn<=0)
        {
            SpawnObstacle();
            timeUntilSpawn = spawnInterval;
        }
  }

  void SpawnObstacle()
    {
        float randomX = Random.Range(-1f, 1f);
        Vector3 spawnPosition= new Vector3(randomX,0.5f,player.position.z+100f);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}