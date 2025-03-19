using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Windows;

public class WordleModel : MonoBehaviour
{
    public int[,] Cell;

    [SerializeField] TextAsset possibleAnswersAsset;
    [SerializeField] TextAsset allowedWordsAsset;

    string[] possibleAnswers;
    string[] allowedWords;


    public string correctAnswer;
    public int currentAttempt;

    public void Setup()
    {
        currentAttempt = 0;

        allowedWords = allowedWordsAsset.text.Split('\n');

        possibleAnswers = possibleAnswersAsset.text.Split('\n');

        int r = Random.Range(0, possibleAnswers.Length);

        correctAnswer = possibleAnswers[r];
    }

    public bool IsValidGuess(string a)
    {
        Debug.Log("Is valid activates");
        bool valid = false;

        if (a.Length != 5 || currentAttempt > 6)
        {
            Debug.Log("INCORRECT NUMBER OF LETTERS");
            valid = false;
        }

        else
        {
            for (int i = 0; i < allowedWords.Length; i++)
            {
                if (a == allowedWords[i])
                {
                    valid = true;
                    currentAttempt++;
                }
            }

            for (int i = 0; i < possibleAnswers.Length; i++)
            {
                if (a == possibleAnswers[i])
                {
                    valid = true;
                    currentAttempt++;
                }
            }
        }
        //return valid;
        return true;
    }

    private void UpdateCells()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                //Cell[r, c].GetComponent<Cell>().letter = Cell[r, c].letter;
            }
        }
    }
}
