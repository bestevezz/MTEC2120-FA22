using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField]
    private float moveSpeed = 5f;
    Vector2 moveDirection = Vector2.zero;
    private Shooter shooterActions;
    private InputAction movement;
    [SerializeField]
    private GameObject laserPrefab;

    private void Awake()
    {
        shooterActions = new Shooter();
    }

    private void OnEnable()
    {
        movement = shooterActions.Player.Movement;
        movement.Enable();

        shooterActions.Player.Shoot.performed += FireLaser;
        shooterActions.Player.Shoot.Enable();
    }

     private void OnDisable()
    {
        
        movement.Disable();
        shooterActions.Player.Shoot.Enable();


    }

    private void FixedUpdate()
    {
        //Debug.Log("Movement values " + movement.ReadValue<Vector2>());
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void Update()
    {
        moveDirection = movement.ReadValue<Vector2>();
    }

   

    void FireLaser(InputAction.CallbackContext obj)
    {
        Instantiate(laserPrefab, transform.position + new Vector3(0, .8f, 0), Quaternion.identity);
        Debug.Log("IM HIT!!!");
    }
}
