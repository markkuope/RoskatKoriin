using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    int score = 0;
    int lives = 3;
    bool gameOver = false;

    public Text scoreText;
    public GameObject livesHolder;
    public GameObject gameOverPanel;

    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InrementScore()
    {
        if (!gameOver)  // peli jatkuu
        {
            score++;
            scoreText.text = score.ToString(); // muutetaan samalla score int -arvosta string -arvoksi
        }
        //print(score);
    }

    public void DecreaseLife()
    {
        if (lives > 0)
        {
            lives--;
            //print(lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
            // Kun lives m‰‰r‰ v‰henee, deaktivoidaan 
            // syd‰met indeksien j‰rjestyksess‰ 2,1,0

        }

        if (lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }

    public void GameOver()
    {
        RoskaSpawner.instance.StopSpawningRoskat();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        // pelaajan liike lakkaa
        gameOverPanel.SetActive(true);

        print("GameOver()");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }



}
