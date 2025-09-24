using UnityEngine;

public class ReactToHit : MonoBehaviour
{
    private GameObject sceneManager;
    private CheckEnemyCount checkEnemyCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
        checkEnemyCount = sceneManager.GetComponent<CheckEnemyCount>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            checkEnemyCount.EnemyKilled();
            Destroy(this.gameObject);
        }
    }
}
