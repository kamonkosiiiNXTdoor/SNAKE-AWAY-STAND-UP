using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    public SnakeDanger snake;

    public void CorrectAnswer()
    {
        snake.CorrectAnswer();
    }

    public void WrongAnswer()
    {
        snake.WrongAnswer();
    }
}