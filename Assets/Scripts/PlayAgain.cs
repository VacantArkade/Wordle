using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgain : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
