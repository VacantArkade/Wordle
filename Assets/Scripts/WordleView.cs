using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class WordleView : MonoBehaviour
{
    [SerializeField] Transform[] rows;
    [SerializeField] WordleModel model;

    [SerializeField] Color fullyCorrectColor;
    [SerializeField] Color partiallyCorrectColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Setup()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                rows[r].GetChild(c).GetComponentInChildren<TMP_Text>().text = " ";
                rows[r].GetChild(c).GetComponent<Image>().color = Color.white;
            }
        }
    }

    private void UpdateView()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                rows[r].GetChild(c).GetComponent<Cell>().letter = model.Cell[r,c].letter;
            }
        }
    }
}
