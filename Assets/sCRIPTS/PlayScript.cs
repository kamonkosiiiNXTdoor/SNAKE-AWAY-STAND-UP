using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Play");
    }
}