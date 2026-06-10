using UnityEngine;

public class SchussMoveScript : MonoBehaviour
{
    public float speed = 5f;
    public float Deadzone = 6f;
    //private float pos = 0;
    //private float mult = 0.5f;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;


        if (transform.position.y > Deadzone)
        {
            Destroy(gameObject);
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("💥 Getroffen: " + collision.gameObject.name + " | Tag: " + collision.tag);

        if (collision.CompareTag("Enemy") || collision.CompareTag("Enemy2"))
        {
            logic.addScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("SchussGegner"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

