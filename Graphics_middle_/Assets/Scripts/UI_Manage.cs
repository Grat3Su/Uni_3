using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manage : MonoBehaviour
{
    public int Score = 0;
    public int HP = 5;
    bool GameOver = false;
    public Text ScoreDisplay;
    public Text HPDisplay;
    public Text FinalScoreDisplay;
    public GameObject Finalpanel;
    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
        {
            GameOver = true;
        }

        if (GameOver == true)
        {
            Time.timeScale = 0.0f; 
            Finalpanel.SetActive(true);
            FinalScoreDisplay.text = "Your Score : "+ Score.ToString();
            if(Input.GetKeyDown(KeyCode.Space))
            {
                 Time.timeScale = 1.0f; 
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else if(Input.GetKeyDown("[0]"))
            {
                 Time.timeScale = 1.0f; 
                SceneManager.LoadScene("Start");
            }

        }
        ScoreDisplay.text = "Score  "+ Score.ToString();
        HPDisplay.text = "Life  " + HP.ToString();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameOver == false)
        {
            if (collision.CompareTag("score"))
            {
                Score++;
                Destroy(collision.gameObject);
            }
            else if (collision.CompareTag("hp"))
            {
                HP--;
                Destroy(collision.gameObject);
            }
        }
        else if (GameOver == true)
        {
            Destroy(collision.gameObject);
        }
    }
}
