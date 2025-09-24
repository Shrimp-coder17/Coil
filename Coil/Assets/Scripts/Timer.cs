using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLimit;
    [SerializeField] private float elapsedTime;
    [SerializeField] private int minutes;
    [SerializeField] private int seconds;
    [SerializeField] private TextMeshProUGUI timerText;
    private bool exceedTimeLimit = false;

    public float ElapsedTime
    {
        get { return elapsedTime; }
    }
    public float TimeLimit
    {
        get { return timeLimit; }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        minutes = Mathf.FloorToInt(elapsedTime / 60);
        seconds = Mathf.FloorToInt(elapsedTime % 60);
        if (minutes >= timeLimit && !exceedTimeLimit)
        {
            Debug.Log("Time Limit Exceeded!");
            exceedTimeLimit = true;
        }
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
