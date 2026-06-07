using UnityEngine;

public class SchussMoveScript : MonoBehaviour
{
    public float speed = 5f;
    public float Deadzone = 4f;
    private float pos = 0;
    private float mult = 0.5f;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        pos += speed * Time.deltaTime * mult;

        if (pos > Deadzone)
        {
            Destroy(gameObject);
        }

        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            logic.addScore();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            logic.addScore();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}

