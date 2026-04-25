using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 플레이어 이동속도
    public Transform cameraTransform;

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
        // 카메라 기준 방향
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // y값 제거 (땅 기준 이동)
        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        // 카메라 기준 이동 벡터 생성
        Vector3 move = forward * input.y + right * input.x;

        // 대각선 속도 보정
        move = move.normalized;

        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
    }
}
    