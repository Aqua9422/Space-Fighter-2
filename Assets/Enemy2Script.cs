using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    public float speed = 0.5f;
    public float Deadzone = -6;
    private float right = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int right = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.x >= 3.25)
            right = 2;
        if (transform.position.x <= -3.25)
            right = 1;
        if ((transform.position.x < 3.25) && (right == 1))
                transform.position += Vector3.right * speed * Time.deltaTime;
        if ((transform.position.x > -3.25) && (right == 2))
                transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.y < Deadzone)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Schuss")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
