using UnityEngine;

public class SchussMoveScript : MonoBehaviour
{
    private float speed = 5f;
    public float Deadzone = 20;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if (transform.position.y > Deadzone)
        {
            Destroy(gameObject);
        }

    }
}

