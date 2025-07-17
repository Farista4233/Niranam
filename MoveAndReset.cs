using UnityEngine;

public class MoveAndReset : MonoBehaviour
{
    public float Distance = 2f;
    public float Speed = 2f;

    private Vector3 startPosition;
    private bool move = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 target = startPosition + (move ? Vector3.left : Vector3.right) * Distance;

        transform.position = Vector3.MoveTowards(transform.position, target, Speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
             transform.position = startPosition;
                move = true;
        }

    }
}