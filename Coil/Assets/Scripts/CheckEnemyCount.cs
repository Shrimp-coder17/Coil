using UnityEngine;

public class CheckEnemyCount : MonoBehaviour
{
    public int enemyNum = 1;
    private SetScreen setScreen;
    private Scoring scoring;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setScreen = GetComponent<SetScreen>();
        scoring = GetComponent<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyKilled()
    {
        enemyNum--;
        if(enemyNum <= 0)
        {
            scoring.GiveScore();
            setScreen.SetNextLevelScreen(true);
        }
    }
}
