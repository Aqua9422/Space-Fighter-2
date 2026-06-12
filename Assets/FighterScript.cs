using UnityEngine;
using UnityEngine.UIElements;


public class FighterScript : MonoBehaviour
{
    public float speed = 5;
    public int hearts = 3;
    public HealthUI healthUI;

    void Start()
    {
        healthUI.UpdateHearts(hearts);
    }

    void Update()
    {
        float move = 0;

        if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < 3.25))
        {
            move = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -3.25))
        {
            move = -1;
        }

        transform.position += Vector3.right * move * speed * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Enemy2" || collision.gameObject.tag == "SchussGegner")
        {
            hearts -= 1;
            healthUI.UpdateHearts(hearts);
            if (hearts <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}