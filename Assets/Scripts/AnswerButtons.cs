using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAYellow; // Yellow is waiting
    public GameObject answerAGreen; // Green is correct
    public GameObject answerARed; // Red is wrong

    public GameObject answerBYellow; // Yellow is waiting
    public GameObject answerBGreen; // Green is correct
    public GameObject answerBRed; // Red is wrong

    public GameObject answerCYellow; // Yellow is waiting
    public GameObject answerCGreen; // Green is correct
    public GameObject answerCRed; // Red is wrong

    public GameObject answerDYellow; // Yellow is waiting
    public GameObject answerDGreen; // Green is correct
    public GameObject answerDRed; // Red is wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public AudioSource correctSound;
    public AudioSource wrongSound;

    
    public TMP_Text currentScore;
    public int scoreVlaue;
    public int highScore;
    public TMP_Text highScoreDisplay;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScoreQuiz");
        highScoreDisplay.text = "High Score: " + highScore;
    }
    private void Update()
    {
        currentScore.text = "Score: " + scoreVlaue;

    }

    public void AnswerA()
    {
        if (QuestionGenerator.realAnswer == "A")
        {
            answerAGreen.SetActive(true);
            answerAYellow.SetActive(false);
            correctSound.Play();
            scoreVlaue += 5; 
        }
        else
        {
            answerARed.SetActive(true);
            answerAYellow.SetActive(false);
            wrongSound.Play();
            scoreVlaue = 0; //Reminder: to subtract score- scoreValue-= 2(any number) 
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
        
    }
    public void AnswerB()
    {
        if (QuestionGenerator.realAnswer == "B")
        {
            answerBGreen.SetActive(true);
            answerBYellow.SetActive(false);
            correctSound.Play();
            scoreVlaue += 5;
        }
        else
        {
            answerBRed.SetActive(true);
            answerBYellow.SetActive(false);
            wrongSound.Play();
            scoreVlaue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }


    public void AnswerC()
    {
        if (QuestionGenerator.realAnswer == "C")
        {
            answerCGreen.SetActive(true);
            answerCYellow.SetActive(false);
            correctSound.Play();
            scoreVlaue += 5;
        }
        else
        {
            answerCRed.SetActive(true);
            answerCYellow.SetActive(false);
            wrongSound.Play();
            scoreVlaue = 0;

        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void AnswerD()
    {
        if (QuestionGenerator.realAnswer == "D")
        {
            answerDGreen.SetActive(true);
            answerDYellow.SetActive(false);
            correctSound.Play();
            scoreVlaue += 5;
        }
        else
        {
            answerDRed.SetActive(true);
            answerDYellow.SetActive(false);
            wrongSound.Play();
            scoreVlaue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }


    IEnumerator NextQuestion()
    {
        if(highScore < scoreVlaue)
        {
            PlayerPrefs.SetInt("HighScoreQuiz", scoreVlaue);
            highScore = scoreVlaue;
            highScoreDisplay.text = "High Score: " + scoreVlaue;
        }
        yield return new WaitForSeconds(1);

        answerAGreen.SetActive(false);
        answerBGreen.SetActive(false);
        answerCGreen.SetActive(false);
        answerDGreen.SetActive(false);
        
        answerARed.SetActive(false);
        answerBRed.SetActive(false);
        answerCRed.SetActive(false);
        answerDRed.SetActive(false);
        
        answerAYellow.SetActive(true);
        answerBYellow.SetActive(true);
        answerCYellow.SetActive(true);
        answerDYellow.SetActive(true);


        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerator.displayingQuestion = false;
    }

}
