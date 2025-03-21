using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordleController : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] WordleModel model;
    [SerializeField] WordleView view;

    public string curWord;

    void Start()
    {
        GameSetup();
    }

    private void Update()
    {
        curWord = input.text.ToLower();
        if(model.currentAttempt >= 6 && !model.IsValidGuess(curWord))
        {
            LoseGame();
        }
    }

    private void GameSetup()
    {
        model.Setup();
        view.Setup();
    }

    public void SubmitGuess()
    {
        curWord = input.text.ToLower();
        if (model.IsValidGuess(curWord) == true)
        {
            view.UpdateView();
            if (curWord.ToString().Trim() == model.correctAnswer.ToString().Trim())
            {
                WinGame();
            }
            model.currentAttempt++;
        }
    }

    private void WinGame()
    {
        SceneManager.LoadScene("Win");
    }

    private void LoseGame()
    {
        SceneManager.LoadScene("Lose");
    }
}
