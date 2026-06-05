using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 0.5f;
    public float Deadzone = -6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < Deadzone)
        {
            Destroy(gameObject);
        }
    }
}
