using UnityEngine;

public class SchussGegner : MonoBehaviour
{
    public float speed = 5f;
    public float Deadzone = -6f;
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
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
            logic.leben();
            if (lives == 0)
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
