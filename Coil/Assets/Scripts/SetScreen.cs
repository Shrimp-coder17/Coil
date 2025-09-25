using UnityEngine;
using UnityEngine.SceneManagement;

public class SetScreen : MonoBehaviour
{
    [SerializeField] private GameObject nextLevelScreen;
    [SerializeField] private GameObject pauseScreen;
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

    public void SetPauseScreen()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
    
    }

    public void UnSetPauseScreen()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void GoLevel1()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void GoLevels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void GoExit()
    {
        Debug.Log("Quiting Game!");
        Application.Quit();
    }

    public void GoTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }








}
