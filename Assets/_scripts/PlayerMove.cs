using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float playerSpeed = 2.0f;
    [SerializeField] float jumpHeight = 1.0f;
    [SerializeField] float gravityValue = -9.81f;
    [SerializeField] Vector3 _moveDirection;
    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    public void Movement(Vector3 direction)
    {
        if (controller.isGrounded)
        {
            _moveDirection = direction;
            _moveDirection *= playerSpeed;
        }
        if (Input.GetButton("Jump") && controller.isGrounded)
        {
            _moveDirection.y = jumpHeight;
        }
        _moveDirection.y -= gravityValue * Time.deltaTime;
        controller.Move(_moveDirection * Time.deltaTime);
    }
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Movement(move);
    }
}
