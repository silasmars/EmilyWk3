using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager:MonoBehaviour
{
          // Entire game has same idea of what score is
       public static GameManager gm;


       public GameObject player;


       public Text scoreText;
       public Text timerText;


       float timer;


       public static int score;


       int coinTotal;

    // Start is called before the first frame update
    void Awake()
       {
          gm = this;
        
        
          coinTotal = GameObject.FindGameObjectsWithTag("Coin").Length;


          timer = 0;
          score = 0;


          UpdateScore();
       }

    // Update is called once per frame
    void Update()
       {
          if(score < coinTotal)
             {
                timer += Time.deltaTime;

                timerText.text = "TIME: " + Mathf.Round(timer*100)/100;
             }


          if (Input.GetKeyDown(KeyCode.R) || player.transform.position.y < -5f)
             {
                SceneManager.LoadScene(0);
             }
        
       }

    public void UpdateScore()
       {
          scoreText.text = "COINS: " + score + "/" + coinTotal;
       }

}
