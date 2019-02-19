using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameController : MonoBehaviour
{
    public Text gameOverText;
    public Text restartText;

    public bool gameOver;
    private bool restart;
    private int health;

    void Start()
    {
        gameOver = false;
        restart = false;
        gameOverText.text = "";
        restartText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
                //Application.LoadLevel(Application.loadedLevel); 
            }
        }
    }

    public void GameOver () 
    {
        gameOverText.text = "Game Over!";
        restartText.text = "press R to restart";
        gameOver = true;
        restart = true; 
    }
}
