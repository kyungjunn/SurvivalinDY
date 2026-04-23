using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput input;
    private PlayerMovement movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = GetComponent<PlayerInput>();
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Move(input.MoveInput);
    }
}
