using UnityEngine;

public class SchussGegnerSpawnScript : MonoBehaviour
{
    public GameObject Schuss;
    public float spawnInterval = 2f;
    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            Instantiate(Schuss, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
