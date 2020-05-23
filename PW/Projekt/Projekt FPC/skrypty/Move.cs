using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float defaultMovementSpeed;

    private CharacterController charController;

    private bool isJumping;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    private void Start()
    {
        defaultMovementSpeed = movementSpeed;
    }

    private void Update()
    {
        PlayerMovement();
        sprint();
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + rightMovement);
    }
    public void setSpeed(float val)
    {
        movementSpeed = val;
    }

    public float getSpeed()
    {
        return defaultMovementSpeed;
    }

    public void sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = defaultMovementSpeed;
        }
    }
}