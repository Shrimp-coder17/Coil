using UnityEngine;

public class SetScreen : MonoBehaviour
{
    [SerializeField] private GameObject nextLevelScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetNextLevelScreen(bool set)
    {
        Time.timeScale = 0f;
        nextLevelScreen.SetActive(set);
    }
}
