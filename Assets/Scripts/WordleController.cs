using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WordleController : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] WordleModel model;
    [SerializeField] WordleView view;

    public string curWord;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            curWord = input.text;
            view.UpdateView();
        }
    }

    private void WinGame()
    {

    }

    private void LoseGame()
    {

    }
}
