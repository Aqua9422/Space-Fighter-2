using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject Enemy;
    public float spawnRate = 2;
    private float timer = 0;
    public float Offset = 10;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnEnemy();
            
            timer = 0;
        }

    }

    void spawnEnemy()
    {
        float furthestPointLeft = transform.position.x - Offset;
        float furthestPointRight = transform.position.x + Offset;

        Instantiate(Enemy, new Vector3( Random.Range(furthestPointLeft, furthestPointRight), transform.position.y, 0), transform.rotation);
    }
}
