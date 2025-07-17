using UnityEngine;
using UnityEngine.InputSystem;

public class ClickToDelete : MonoBehaviour
{
    private PlayerControls _controls;
    private bool _playerInside = false;

    void Awake()
    {
        _controls = new PlayerControls();

        _controls.Gameplay.HO.performed += ctx =>
        {
            if (_playerInside)
            {
                gameObject.SetActive(false);
            }
        };
    }

    void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        _controls.Gameplay.Disable();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playerInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playerInside = false;
        }
    }
}