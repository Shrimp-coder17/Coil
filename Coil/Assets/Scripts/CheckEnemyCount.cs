using UnityEngine;

public class CheckEnemyCount : MonoBehaviour
{
    public int enemyNum = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyKilled()
    {
        enemyNum--;
    }
}
