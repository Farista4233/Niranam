using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Vector3 rotationSpeed = new Vector3(0f, 0f, 100f);

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }

}