using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Board : MonoBehaviour
{

    [SerializeField] TMP_InputField myTextInput;
    [SerializeField] Button[] row0;
    [SerializeField] Button[] row1;
    [SerializeField] Button[] row2;

    int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AcceptInput()
    {
        string word = myTextInput.text.ToLower();

        if (word.Length != 5)
        {
            Debug.Log("INCORRECT NUMBER OF LETTERS");
            return;
        }

        switch (count)
        {
            case 0:
                for(int i = 0; i < row0.Length; i++)
                {
                    row0[i].GetComponentInChildren<TMP_Text>().text = word[i].ToString();
                }
                break;
            case 1:
                for (int i = 0; i < row1.Length; i++)
                {
                    row1[i].GetComponentInChildren<TMP_Text>().text = word[i].ToString();
                }
                break;
            case 2:
                for (int i = 0; i < row2.Length; i++)
                {
                    row2[i].GetComponentInChildren<TMP_Text>().text = word[i].ToString();
                }
                break;
        }
        
        
        count += 1;
    }
}
