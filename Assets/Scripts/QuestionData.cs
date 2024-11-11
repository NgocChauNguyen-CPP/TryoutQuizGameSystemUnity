using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//We will make it easier to create new ScriptableObject assets of type "Question" from the Unity Editor. 
[CreateAssetMenu(fileName = "Question", menuName = "ScriptableObjects/Question", order = 1)]
public class QuestionData : ScriptableObject
{
    public string quesiton;
    public string category;
    [Tooltip("The correct answer will always be listed first. Then, we will randomize the order later.")]
    public string[] answers;

}
