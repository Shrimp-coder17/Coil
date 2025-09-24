using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float elapsedTime;
    [SerializeField] private float min;
    [SerializeField] private TextMeshProUGUI timerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        min = elapsedTime/60;
        timerText.text = string.Format("{0:00}:{1:00}", min, elapsedTime);
    }
}
