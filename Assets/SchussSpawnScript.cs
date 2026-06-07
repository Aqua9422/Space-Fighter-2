using System.Threading;
using UnityEngine;

public class SchussSpawnScript : MonoBehaviour
{
    public GameObject schuss;
    public float spawnRate = 2;
    private float timer = 0;
    public float firerate = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && (timer >= firerate ))
        {
            Instantiate(schuss, transform.position, transform.rotation);
            timer = 0;
            
        }
        
    }
}
