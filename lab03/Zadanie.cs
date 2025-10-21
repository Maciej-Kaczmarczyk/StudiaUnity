using UnityEngine;

public class MoveX: MonoBehaviour
{
    public float speed = 1f;
    private Vector3 startPosition;
    private const float TravelDistance = 10f;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float offsetX = Mathf.PingPong(Time.time * speed, TravelDistance);
        Vector3 newPosition = startPosition + Vector3.right * offsetAlongX;
        transform.position = newPosition;
    }
}
