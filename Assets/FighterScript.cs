using UnityEngine;
using UnityEngine.UIElements;

public class FighterScript : MonoBehaviour
{
    public float speed = 5;

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit: " + collision.gameObject.name);
        if (collision.gameObject.tag == "SchussGegner")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }  
}