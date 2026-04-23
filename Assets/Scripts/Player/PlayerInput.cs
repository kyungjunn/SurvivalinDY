using UnityEngine;
using UnityEngine.InputSystem; // 새로운 Input System

public class PlayerInput : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; }

    public void OnMove(InputValue value)
    {
        MoveInput = value.Get<Vector2>();
    }
}
