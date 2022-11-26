using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public static string realAnswer;
    public static  bool displayingQuestion = false;
    public int questionNumber;


    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 7);
            if (questionNumber == 1)
            {
                
                Questions.newQuestion = "How many Chemical elements do we have?";
                Questions.newAnswerA = "A. 118";
                Questions.newAnswerB = "B. 119";
                Questions.newAnswerC = "C. 109";
                Questions.newAnswerD = "D. 140";
                realAnswer = "A";
            }


            if (questionNumber == 2)
            {
                
                Questions.newQuestion = "What is the Chemical element for symbol ES?";
                Questions.newAnswerA = "A. Europium";
                Questions.newAnswerB = "B. Erbium";
                Questions.newAnswerC = "C. Samarium";
                Questions.newAnswerD = "D. Einstenium";
                realAnswer = "D";
            }

            if (questionNumber == 3)
            {
                
                Questions.newQuestion = "What is the Chemical element for symbol N?";
                Questions.newAnswerA = "A. Nickel";
                Questions.newAnswerB = "B. Nitrogen";
                Questions.newAnswerC = "C. Niobium";
                Questions.newAnswerD = "D. Neptunium";
                realAnswer = "B";
            }

            if (questionNumber == 4)
            {
                
                Questions.newQuestion = "What is the Chemical element for symbol O?";
                Questions.newAnswerA = "A. Oganesson";
                Questions.newAnswerB = "B. Osmium";
                Questions.newAnswerC = "C. Nobelium";
                Questions.newAnswerD = "D. Oxygen";
                realAnswer = "D";
            }

            if (questionNumber == 5)
            {
                
                Questions.newQuestion = "What is the Chemical element for symbol H?";
                Questions.newAnswerA = "A. Hydrogen";
                Questions.newAnswerB = "B. Nitrogen";
                Questions.newAnswerC = "C. Nobelium";
                Questions.newAnswerD = "D. Indium";
                realAnswer = "A";

            } if (questionNumber == 6)
            {
                
                Questions.newQuestion = "Sage Hub has how many Members?";
                Questions.newAnswerA = "A. 6";
                Questions.newAnswerB = "B. 4";
                Questions.newAnswerC = "C. 3";
                Questions.newAnswerD = "D. 2";
                realAnswer = "B";
            }


            //All questions to generate should go Above this line

            Questions.updateQuestions = false;
        }
    }
}
