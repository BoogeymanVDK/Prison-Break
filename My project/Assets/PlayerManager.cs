using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public TimeSlider timeSlider; 
    public GameObject Player;
    private void Awake()
    {
        isGameOver =false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
            Player.SetActive(false);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(1);
        
    }
}
