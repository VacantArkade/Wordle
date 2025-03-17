using UnityEngine;
using UnityEngine.Rendering;

public class WordleModel : MonoBehaviour
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
        possibleAnswers = possibleAnswersAsset.text.Split('\n');

        int r = Random.Range(0, possibleAnswers.Length);

        correctAnswer =  possibleAnswers[r];
    }

    private void isValidGuess(string a)
    {

    }

    private void UpdateCells()
    {

    }
}
