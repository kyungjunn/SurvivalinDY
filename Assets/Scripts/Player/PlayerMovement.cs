using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 플레이어 이동속도

    private PlayerInput playerInput;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move();
    }

    public void Move(Vector2 input)
    {
        Vector3 move = new Vector3(input.x, 0f, input.y).normalized;

        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
    }
}
