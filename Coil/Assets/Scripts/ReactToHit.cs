using UnityEngine;

public class ReactToHit : MonoBehaviour
{
    private GameObject sceneManager;
    private CheckEnemyCount checkEnemyCount;
    private ParticleSpawner particleSpawner;
    private Rigidbody2D rb; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
        checkEnemyCount = sceneManager.GetComponent<CheckEnemyCount>();
        particleSpawner = sceneManager.GetComponent<ParticleSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            particleSpawner.SpawnParticle(transform.position);
            collision.gameObject.SetActive(false);
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            checkEnemyCount.EnemyKilled();
            Destroy(this.gameObject);
        }
    }
}
