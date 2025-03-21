using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
public class WordleView : MonoBehaviour
{
    [SerializeField] Transform[] rows;
    [SerializeField] WordleModel model;
    [SerializeField] WordleController controller;

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

    public void UpdateView()
    {
        for (int c = 0; c < 5; c++)
        {
            rows[model.currentAttempt].GetChild(c).GetComponentInChildren<TMP_Text>().text = controller.curWord[c].ToString();

            if (model.correctAnswer[c] == controller.curWord[c])
            {
                rows[model.currentAttempt].GetChild(c).GetComponent<Image>().color = Color.green;
            }

            else if (model.correctAnswer.Contains(controller.curWord[c]))
            {
                rows[model.currentAttempt].GetChild(c).GetComponent<Image>().color = Color.yellow;
            }

            else
            {
                rows[model.currentAttempt].GetChild(c).GetComponent<Image>().color = Color.gray;
            }
        }
    }
}
