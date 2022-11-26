using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAYellow; // Yellow is waiting
    public GameObject answerAGreen; // Green is correct
    public GameObject answerARed; // Res is wrong

    public GameObject answerBYellow; // Yellow is waiting
    public GameObject answerBGreen; // Green is correct
    public GameObject answerBRed; // Res is wrong

    public GameObject answerCYellow; // Yellow is waiting
    public GameObject answerCGreen; // Green is correct
    public GameObject answerCRed; // Res is wrong

    public GameObject answerDYellow; // Yellow is waiting
    public GameObject answerDGreen; // Green is correct
    public GameObject answerDRed; // Res is wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public void AnswerA()
    {
        if (QuestionGenerator.realAnswer == "A")
        {
            answerAGreen.SetActive(true);
            answerAYellow.SetActive(false);
        }
        else
        {
            answerARed.SetActive(true);
            answerAYellow.SetActive(false);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        
    }
    public void AnswerB()
    {
        if (QuestionGenerator.realAnswer == "B")
        {
            answerBGreen.SetActive(true);
            answerBYellow.SetActive(false);
        }
        else
        {
            answerBRed.SetActive(true);
            answerBYellow.SetActive(false);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }


    public void AnswerC()
    {
        if (QuestionGenerator.realAnswer == "C")
        {
            answerCGreen.SetActive(true);
            answerCYellow.SetActive(false);
        }
        else
        {
            answerCRed.SetActive(true);
            answerCYellow.SetActive(false);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }
    public void AnswerD()
    {
        if (QuestionGenerator.realAnswer == "D")
        {
            answerDGreen.SetActive(true);
            answerDYellow.SetActive(false);
        }
        else
        {
            answerDRed.SetActive(true);
            answerDYellow.SetActive(false);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }




}
