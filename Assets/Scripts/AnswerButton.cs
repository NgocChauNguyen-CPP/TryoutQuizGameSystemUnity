using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    private bool isCorrect;
    [SerializeField]
    private TextMeshProUGUI answerText;

    public void SetAnswerText(string myAnswerText) //get the answer text from another script
    {
        answerText.text = myAnswerText;
    }

    public void SetIsCorrect(bool correctStatus)
    {
        isCorrect = correctStatus;
    }

    public void OnClick()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer.");
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
}
