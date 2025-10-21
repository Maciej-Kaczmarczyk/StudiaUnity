using UnityEngine;

public class MoveInSquare: MonoBehaviour
{
    public float speed = 2f;
    public float sideLength = 10f;
    private Vector3 startPosition;
    private int sidesCompleted = 0;
    private bool isTurning = false;
    private Quaternion targetRotation;

    private void Start()
    {
        startPosition = transform.position;
        transform.rotation = Quaternion.identity;
    }

    private void Update()
    {
        if (!isTurning)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            float distance = Vector3.Distance(startPosition, transform.position);
            if (distance >= sideLength)
            {
                isTurning = true;
                startPosition = transform.position;
                sidesCompleted++;
                targetRotation = transform.rotation * Quaternion.Euler(0, 90f, 0);
            }
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 90f * Time.deltaTime);
            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                transform.rotation = targetRotation;
                isTurning = false;
            }
        }
    }
}
