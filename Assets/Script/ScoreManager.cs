using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManagerStatic;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        scoreManagerStatic = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    { 
        score++;
        //Debug.Log("Score = " + score);

        scoreText.text = "Score: " + score.ToString();  
    }
}
