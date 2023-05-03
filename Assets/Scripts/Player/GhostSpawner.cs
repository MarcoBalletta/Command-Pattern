using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GhostSpawner : MonoBehaviour
{
    private InputManager inputManager;
    private PlayerMovement movement;
    private RecordingComponent recordingComponent;
    [SerializeField] private GhostController ghostPrefab;

    private void OnEnable()
    {
        if (recordingComponent == null) recordingComponent = GetComponent<RecordingComponent>();
        if (movement == null) movement = GetComponent<PlayerMovement>();
        if (inputManager == null) inputManager = GetComponent<InputManager>();
        inputManager.onSpawnGhost += Spawn;
    }

    private void Spawn()
    {
        var ghost = Instantiate(ghostPrefab, recordingComponent.RecordingPosition, Quaternion.identity);
        ghost.Setup(movement.Speed, movement.JumpForce, recordingComponent.MapCommands);
    }
}
