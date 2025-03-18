using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] WordleModel model;
    [SerializeField] WordleView view;


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

    private void SubmitGuess()
    {
        if (model.IsValidGuess(input.text) == true)
        {

        }
    }

    private void WinGame()
    {

    }

    private void LoseGame()
    {

    }
}
