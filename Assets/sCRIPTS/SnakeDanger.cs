using UnityEngine;

public class SnakeDanger : MonoBehaviour
{
    [Header("Movement")]
    public float moveDistance = 1.5f;
    public float moveSpeed = 3f;

    [Header("Limits")]
    public float closestPosition = -3f;
    public float farthestPosition = 8f;

    private float targetX;

    void Start()
    {
        targetX = transform.position.x;
    }

    void Update()
    {
        Vector3 targetPosition = new Vector3(
            targetX,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            moveSpeed * Time.deltaTime
        );
    }

    public void CorrectAnswer()
    {
        targetX += moveDistance;

        targetX = Mathf.Clamp(
            targetX,
            closestPosition,
            farthestPosition
        );
    }

    public void WrongAnswer()
    {
        targetX -= moveDistance;

        targetX = Mathf.Clamp(
            targetX,
            closestPosition,
            farthestPosition
        );
    }
}