using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnRate = 2f;
    private float timer = 0;
    public float Offset = 10;
    public float schwierigkeit = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPipe();
    }

    // Update is called once per frame

    void Update()
    {
        timer += Time.deltaTime;

        //  Spawn unabhängig
        if (timer >= spawnRate)
        {
            spawnEnemy();
            timer = 0;
        }

        //  Difficulty unabhängig
        if (Time.time >= schwierigkeit)
        {
            spawnRate *= 0.9f;
            schwierigkeit *= 2f;
        }
    }


    void spawnEnemy()
    {
        float furthestPointLeft = transform.position.x - Offset;
        float furthestPointRight = transform.position.x + Offset;

        Instantiate(Enemy, new Vector3( Random.Range(furthestPointLeft, furthestPointRight), transform.position.y, 0), transform.rotation);
    }
}
