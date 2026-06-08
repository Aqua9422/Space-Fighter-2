using UnityEngine;

public class SchussGegner : MonoBehaviour
{
    public float speed = 5f;
    public float Deadzone = -6f;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Fighter")
        {
            logic.addScore();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Schuss")
        {
            
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
