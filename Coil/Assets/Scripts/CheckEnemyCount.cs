using System.Collections;
using System.Collections.Generic;
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
            StartCoroutine(SetNextLevel());
        }
    }

    private IEnumerator SetNextLevel()
    {
        scoring.GiveScore();
        yield return new WaitForSeconds(3f);
        setScreen.SetNextLevelScreen(true);
    }
}
