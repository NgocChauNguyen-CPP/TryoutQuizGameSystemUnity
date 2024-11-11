using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionSetup : MonoBehaviour
{
    [SerializeField]
    private List<QuestionData> myAllQuestions;
    private QuestionData myCurrentQuestion; //keep track of which questions we are currently on. 

    //Also, we will not repeat questions throughout one session. 

    [SerializeField]
    private TextMeshProUGUI myQuestionText;
    [SerializeField]
    private TextMeshProUGUI myCategoryText;
    [SerializeField]
    private AnswerButton[] myAllAnswerButtons;

    [SerializeField]
    private int correctAnswerChoice;
    // Start is called before the first frame update

    //May put this into different function depending on when it starts in my game. 
    private void Awake()
    {
        GetQuestionAssets(); //definition of this function is below. 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetQuestionAssets()
    {
        //Get all of the questions from the questions folder/
        //Tell Unity to load all assets of type QuestionData from a folder. 
        //"Questions" is the path within my Resources folder where Unity should look 
        //for the QuestionData assets. 
        //Resources.LoadAll<QuestionData>("Questions") loads all QuestionData assets in the Questions folder 
        //and reutns them as an array of QuestionData objects.  
        myAllQuestions = new List<QuestionData>(Resources.LoadAll<QuestionData>("Questions"));
    }
}
