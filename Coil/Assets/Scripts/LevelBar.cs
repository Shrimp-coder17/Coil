using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class LevelBar : MonoBehaviour
{
    [SerializeField] private Image levelBar;
    [SerializeField] private TextMeshProUGUI levelText;
    private float levelFill = 0f;
    private int level = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLevelBar(float add)
    {
        add *= 10;
        levelFill += add;
        levelFill = Mathf.Clamp(levelFill, 0, 100);
        if (levelFill >= 100)
        {
            levelFill = 0;
            level++;
            levelText.text = "Level "+ level.ToString();
        }
        levelBar.fillAmount = levelFill/100;
    }
}
