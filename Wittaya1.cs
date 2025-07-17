using UnityEngine;
using UnityEngine.InputSystem;

public class Wittaya1 : MonoBehaviour
{
    private SpriteRenderer _IDK;

    public InputAction _action;

    void OnEnable()
    {
        _action.Enable();
    }

    void OnDisable()
    {
        _action.Disable();
    }

    void Start()
    {
        _IDK = GetComponent<SpriteRenderer>();
    }

}