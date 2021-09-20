using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movement;
    PlayerControls controls;
    PlayerControls.GroundMovementActions groundMovement;
    // Start is called before the first frame update
    Vector2 horizontalInput;
   private void Awake()
    {
        controls = new PlayerControls();
        groundMovement = controls.GroundMovement;
        groundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
    }
    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
    }
    private void OnEnable()
    {
        controls.Enable();
    } 
    private void OnDestroy()
    {
        controls.Disable();
    }
}
