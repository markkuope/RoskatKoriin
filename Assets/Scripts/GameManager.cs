using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    bool gameOver = false;

    public Text scoreText;

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
        score++;
        scoreText.text = score.ToString(); // muutetaan samalla score int -arvosta string -arvoksi
        //print(score);
    }



}
