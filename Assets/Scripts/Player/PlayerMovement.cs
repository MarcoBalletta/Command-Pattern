using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class PlayerMovement : BaseCharacter
{

    private InputManager inputManager;
    private MovementCommand movement;
    private float movementValue;
    private RecordingComponent recordingComponent;

    protected override void Awake()
    {
        base.Awake();
        inputManager = GetComponent<InputManager>();
        recordingComponent = GetComponent<RecordingComponent>();
        movement = new MovementCommand();
    }

    private void OnEnable()
    {
        inputManager.onPerformTranslate += EnterCommand;
        inputManager.onPerformTranslate += SetMovementValue;
        inputManager.onCanceledTranslate += EnterCommand;
        inputManager.onCanceledTranslate += SetMovementValue;
    }

    private void FixedUpdate()
    {
        movement.Execute(this, movementValue);
    }

    private void EnterCommand(InputAction.CallbackContext context)
    {
        if (!recordingComponent.IsRecording) return;
        var movementValue = context.ReadValue<float>();
        if (movementValue == 0)
            recordingComponent.AddCommand(TypeOfCommand.idle);
        else if(movementValue > 0)
            recordingComponent.AddCommand(TypeOfCommand.moveRight);
        else 
            recordingComponent.AddCommand(TypeOfCommand.moveLeft);
    }

    private void SetMovementValue(InputAction.CallbackContext context)
    {
        movementValue = context.ReadValue<float>();
    }
}
