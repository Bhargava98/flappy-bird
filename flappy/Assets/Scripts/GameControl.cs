using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject gameOverText ;
    public Text scoreText;
    public GameObject gameoverImage;
    public bool gameOver = false;

    private int score = 0;

	// Use this for initialization
	void Awake ()
    {
		if(instance == null)
        {
            instance = this;
        }
        else if(instance!= this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BirdScored()
    {
        if(gameOver)
        {
            return;
        }
        score++;
        scoreText.text = score.ToString();
    }

    public void BirdDed()
    {
        gameOverText.SetActive(true);
        gameOver = true;
        gameoverImage.SetActive(true);
    }
}
