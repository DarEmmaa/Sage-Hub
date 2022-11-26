using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Questions : MonoBehaviour
{
    [SerializeField] private TMP_Text questionDisplay;
    [SerializeField] private TMP_Text answerA;
    [SerializeField] private TMP_Text answerB;
    [SerializeField] private TMP_Text answerC;
    [SerializeField] private TMP_Text answerD;

    public static string newQuestion;
    public static string newAnswerA;
    public static string newAnswerB;
    public static string newAnswerC;
    public static string newAnswerD;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PushQuestions());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PushQuestions()
    {
        yield return new WaitForSeconds(0.25f);
        questionDisplay.text = newQuestion;
        answerA.text = newAnswerA;
        answerB.text = newAnswerB;
        answerC.text = newAnswerC;
        answerD.text = newAnswerD;
    }
}
