using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string realAnswer;
    public static  bool displayingQuestion = false;


    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            Questions.newQuestion = "How many elements do we have?";
            Questions.newAnswerA = "A. 118";
            Questions.newAnswerB = "B. 119";
            Questions.newAnswerC = "C. 109";
            Questions.newAnswerD = "D. 140";
            realAnswer = "A";
        }
    }
}
