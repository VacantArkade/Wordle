using UnityEngine;

public class NewMonoBehaviourScript2 : MonoBehaviour
{
    [SerializeField] Transform[,] rows;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Setup()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                rows[r, c].GetChild(c).GetComponent<Cell>().letter = ' ';
            }
        }
    }

    private void UpdateView()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                rows[r, c].GetChild(c).GetComponent<Cell>().letter = ' ';
            }
        }
    }
}
