using UnityEngine;
using UnityEngine.InputSystem;

public class Wittaya : MonoBehaviour
{
    private SpriteRenderer _IDK;
    public Sprite _Img;
    public Sprite _Pimg;
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

    void Update()
    {
        if (_action.WasPressedThisFrame())
        {
            _IDK.sprite = _Pimg;
        }

        if (_action.WasReleasedThisFrame())
        {
            _IDK.sprite = _Img;
        }
    }
}