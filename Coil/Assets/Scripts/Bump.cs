using UnityEngine;

public class Bump : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 4.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LWall"))
        {
            Vector2 direction = transform.right;
            transform.localEulerAngles = new Vector3(0, 0, 0);
            rb.linearVelocity = direction * speed;
        }

        if (collision.gameObject.CompareTag("RWall"))
        {
            Vector2 direction = -transform.right;
            transform.localEulerAngles = new Vector3(0, 0, 0);
            rb.linearVelocity = direction * speed;
        }
    }
}
