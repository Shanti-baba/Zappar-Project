using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    public TMP_Text score;
    public int scoreValue = 0;
    public int lives = 3;
    public float gameOverTimer;
    public Image [] livesImages;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            scoreValue++;
        }

        if (other.gameObject.CompareTag("Barrier"))
        {
            other.gameObject.SetActive(false);
            lives--;
            if(lives == 2)
            {
                livesImages[2].GetComponent<Image>().enabled = false;
            }

            if (lives == 1)
            {
                livesImages[1].GetComponent<Image>().enabled = false;
            }

            if (lives == 0)
            {
                livesImages[0].GetComponent<Image>().enabled = false;
                Invoke("GameOver", gameOverTimer);
            }
        }
    }

    private void Update()
    {
        score.text = "" + scoreValue;
    }

    void GameOver()
    {
        Time.timeScale = 0;
    }

}
