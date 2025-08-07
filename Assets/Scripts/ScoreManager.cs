using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    [SerializeField]private TMP_Text scoreText;
    private int score =0;

    private void Awake()
    {
        if (Instance !=null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateUI();
    }
    private void UpdateUI()
    {
        if (scoreText !=null)
        {
            scoreText.text = "Score:-" + score;
        }
    }
}
