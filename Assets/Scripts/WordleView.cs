using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class WordleView : MonoBehaviour
{
    [SerializeField] Transform[] rows;
    [SerializeField] WordleModel model;
    [SerializeField] WordleController controller;

    [SerializeField] Color fullyCorrectColor;
    [SerializeField] Color partiallyCorrectColor;

    public void Setup()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                rows[r].GetChild(c).GetComponentInChildren<TMP_Text>().text = " ";
                rows[r].GetChild(c).GetComponent<Image>().color = Color.blue;
            }
        }
    }

    public void UpdateView()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                //rows[r].GetChild(c).GetComponent<Cell>().letter = controller.curWord[c];
                rows[r].GetChild(c).GetComponentInChildren<TMP_Text>().text = controller.curWord[c].ToString();
            }
        }
    }
}
