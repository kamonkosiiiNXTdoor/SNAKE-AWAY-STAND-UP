using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TapToContinue : MonoBehaviour
{
    public string nextScene = "Game";

    void Update()
    {
        // Mouse click
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Continue();
        }

        // Touch screen
        if (Touchscreen.current != null &&
            Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            Continue();
        }
    }

    void Continue()
    {
        SceneManager.LoadScene(nextScene);
    }
}