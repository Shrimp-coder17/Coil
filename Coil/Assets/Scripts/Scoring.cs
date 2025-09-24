using UnityEngine;

public class Scoring : MonoBehaviour
{
    [SerializeField] private GameObject StarOne;
    [SerializeField] private GameObject StarTwo;
    [SerializeField] private GameObject StarThree;
    private Timer timer;
    private float third = 3f;
    private float half = 2f;
    private float timeLimitInSeconds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = GetComponent<Timer>();
        timeLimitInSeconds = timer.TimeLimit * 60f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveScore()
    {
        if (timer.ElapsedTime <= timeLimitInSeconds / third)
        {
            Debug.Log("Star: 3");
            StarOne.SetActive(true);
            StarTwo.SetActive(true);
            StarThree.SetActive(true);
        }
        else if(timer.ElapsedTime <= timeLimitInSeconds / half)
        {
            Debug.Log("Star: 2");
            StarOne.SetActive(true);
            StarTwo.SetActive(true);
            StarThree.SetActive(false);
        }
        else
        {
            Debug.Log("Star: 1");
            StarOne.SetActive(true);
            StarTwo.SetActive(false);
            StarThree.SetActive(false);
        }
    }
}
