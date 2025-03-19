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

    //public bool ready = true;

    void Start()
    {
        GameSetup();
    }

    private void GameSetup()
    {
        model.Setup();
        view.Setup();
    }

    public void SubmitGuess()
    {
        if (model.IsValidGuess(input.text) == true)
        {
            curWord = input.text.ToLower();
            view.UpdateView();
            if (curWord == model.correctAnswer.ToString())
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
        GameSetup();
    }
}
