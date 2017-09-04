using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public int cash;
    public int bankPin;
    public string myName;
    CharacterController controller = GetComponent<CharacterController>();

    private Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
