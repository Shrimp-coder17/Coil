using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 9.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.freezeRotation = true;
        }
        Vector2 direction = transform.right;
        rb.linearVelocity = direction * speed;
        StartCoroutine(DestroyBullet());
    }
    // Update is called once per frame
    void Update()
    { 
    
    }

    private IEnumerator DestroyBullet()
    {
        Debug.Log("Destroying Bullet!");
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }

}
