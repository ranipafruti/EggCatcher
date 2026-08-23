using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseButton; 
    [SerializeField] private GameObject playButton;   

    private void Start()
    {
      
        pauseButton.SetActive(true);
        playButton.SetActive(false);
        Time.timeScale = 1f;  
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;  
        pauseButton.SetActive(false); 
        playButton.SetActive(true);  
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;  
        pauseButton.SetActive(true);   
        playButton.SetActive(false);   
    }
}
