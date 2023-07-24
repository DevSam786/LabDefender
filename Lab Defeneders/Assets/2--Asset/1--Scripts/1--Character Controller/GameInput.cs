using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    public Vector2 inputVector;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }
    public Vector2 GetInputVectorNormalized()
    {
        
        inputVector = playerInputActions.Player.Move.ReadValue<Vector2>(); 
        inputVector= inputVector.normalized;
        return inputVector;
    }
    
}
