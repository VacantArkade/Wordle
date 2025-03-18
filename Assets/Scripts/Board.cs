using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    [SerializeField] TMP_InputField myTextInput;
    [SerializeField] Button[] row0;
    [SerializeField] Button[] row1;
    [SerializeField] Button[] row2;
    [SerializeField] Button[] row3;
    [SerializeField] Button[] row4;
    [SerializeField] Button[] row5;

    int count = 0;

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
            case 3:
                for (int i = 0; i < row3.Length; i++)
                {
                    row3[i].GetComponentInChildren<TMP_Text>().text = word[i].ToString();
                }
                break;
            case 4:
                for (int i = 0; i < row4.Length; i++)
                {
                    row4[i].GetComponentInChildren<TMP_Text>().text = word[i].ToString();
                }
                break;
            case 5:
                for (int i = 0; i < row5.Length; i++)
                {
                    row5[i].GetComponentInChildren<TMP_Text>().text = word[i].ToString();
                }
                break;
        }
        
        
        count += 1;
    }
}
