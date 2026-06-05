using UnityEngine;

public class SchussMoveScript : MonoBehaviour
{
    public float speed = 5f;
    public float Deadzone = 4f;
    private float pos = 0;
    private float mult = 0.5f;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        pos += speed * Time.deltaTime * mult;

        if (pos > Deadzone)
        {
            Destroy(gameObject);
        }

        

    }
}

