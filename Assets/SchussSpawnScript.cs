using UnityEngine;

public class SchussSpawnScript : MonoBehaviour
{
    public GameObject schuss;
    public float spawnRate = 2;
    //private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(schuss, transform.position, transform.rotation);
            
        }
        
    }
}
