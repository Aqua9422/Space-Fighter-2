using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 0.5f;
    public float Deadzone = -6;
    public int hearts = 3;
    public HealthUI healthUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthUI = FindAnyObjectByType<HealthUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < Deadzone)
        {
            GameManager.instance.TakeDamage(1);
            Destroy(gameObject);
        }
    }

    


}
