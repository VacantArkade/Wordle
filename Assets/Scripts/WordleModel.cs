using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    int[,] Cell;

    [SerializeField] TextAsset possibleAnswersAsset;
    [SerializeField] TextAsset allowedWordsAsset;

    string[] possibleAnswers;
    string[] allowedWords;

    string correctAnswer;
    int currentAttempt;

    public void Setup()
    {

    }

    private void isValidGuess(string a)
    {

    }

    private void UpdateCells()
    {

    }
}
