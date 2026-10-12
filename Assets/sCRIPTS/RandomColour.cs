using UnityEngine;
using UnityEngine.UI;

public class RandomColour : MonoBehaviour
{
    public Image buttonBackground;

    public void ButtonClicked()
    {
        if (Random.value < 0.5f)
        {
            // Green
            buttonBackground.color = new Color32(46, 125, 50, 255);
        }
        else
        {
            // Red
            buttonBackground.color = new Color32(198, 40, 40, 255);
        }
    }
}