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
        

        if (collision.CompareTag("Enemy") || collision.CompareTag("Enemy2"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (collision.CompareTag("Enemy"))
            {
                logic.addScore(100);
            }
            else if (collision.CompareTag("Enemy2"))
            {
                logic.addScore(200);
            }
        }
        else if (collision.CompareTag("SchussGegner"))
        {
            
            Destroy(gameObject);
        }
    }
}

