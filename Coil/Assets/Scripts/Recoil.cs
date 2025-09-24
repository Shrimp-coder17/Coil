using UnityEngine;

public class Recoil : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReactRecoil()
    {
        Vector2 direction = -transform.right;
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }

   
}
