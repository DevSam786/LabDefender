using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameInput gameInput;
    private bool canMove;
    [HideInInspector]public Vector2 input;
    

    [Header("Dash")]
    // Dash Settings
    public float dashDuration = 0.2f;    // Duration of the dash in seconds
    public float dashDistance = 5.0f;    // Distance covered during the dash

    // Player Variables
    private bool isDashing = false;      // Flag indicating if the player is currently dashing
    private float dashTimer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Only Dash Mechanics
        if (Input.GetKeyDown(KeyCode.Space) && !isDashing)
        {
            InitiateDash();
        }
        DashPlayer();

        //Only MoveMent & Enteraction
        HandleMovement();
        
    }

    void HandleMovement()
    {
        input = gameInput.GetInputVectorNormalized();
        Vector3 moveDir = new Vector3(input.x, 0, input.y);

        float moveDistance = moveSpeed * Time.deltaTime;
        float playerHeight = 1.49f;
        float playerRadius = 0.20f;
        canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDir,moveDistance);
        if (canMove)
        {
            transform.position += moveDir * moveSpeed * Time.deltaTime;
        }
    }    
    void HandleInteraction()
    {

    }
    void HandleAiming()
    {
        
    }

    void InitiateDash()
    {
        isDashing = true;
        dashTimer = 0.0f;

        // TODO: Add any dash-specific effects or animations here
    }

    void DashPlayer()
    {
        if (isDashing)
        {
            // Calculate dash movement based on dash distance and duration
            float dashSpeed = dashDistance / dashDuration;
            Vector2 dashInput = gameInput.GetInputVectorNormalized();

            Vector3 dashMovement = new Vector3(dashInput.x,0,dashInput.y) * dashSpeed;
            bool canDash = !Physics.Raycast(transform.position, dashMovement, dashDistance);//To not dash from obstacle

            // Update player position
            if (canDash)
            {
                transform.position += dashMovement * Time.deltaTime;

            }

            // Update dash timer
            dashTimer += Time.deltaTime;

            // Check if the dash duration has elapsed
            if (dashTimer >= dashDuration)
            {
                isDashing = false;

                // TODO: Add any post-dash logic here
            }
        }        
    }
}
