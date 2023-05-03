using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    InputActions actions;

    public delegate void OnPerformTranslate(InputAction.CallbackContext context);
    public OnPerformTranslate onPerformTranslate;

    public delegate void OnCanceledTranslate(InputAction.CallbackContext context);
    public OnCanceledTranslate onCanceledTranslate;

    public delegate void OnPerformJump(InputAction.CallbackContext context);
    public OnPerformJump onPerformJump;

    public delegate void OnToggleRecording();
    public OnToggleRecording onToggleRecording;

    public delegate void OnSpawnGhost();
    public OnSpawnGhost onSpawnGhost;


    private void Awake()
    {
        actions = new InputActions();
    }

    private void OnEnable()
    {
        actions.Enable();
        actions.MovementPlayer.Translate.performed += PerformTranslate;
        actions.MovementPlayer.Translate.canceled += CanceledTranslate;
        actions.Recording.ToggleRecording.performed += ToggleRecording;
        actions.GhostSpawn.Spawn.performed += SpawnGhost;
    }



    private void OnDisable()
    {
        actions.Disable();
    }

    private void PerformTranslate(InputAction.CallbackContext context)
    {
        if (onPerformTranslate == null) return;

        onPerformTranslate(context);
    }

    private void CanceledTranslate(InputAction.CallbackContext context)
    {
        if (onCanceledTranslate == null) return;

        onCanceledTranslate(context);
    }

    private void ToggleRecording(InputAction.CallbackContext context)
    {
        if (onToggleRecording == null) return;
        onToggleRecording();
    }

    private void SpawnGhost(InputAction.CallbackContext obj)
    {
        if (onSpawnGhost == null) return;
        onSpawnGhost();
    }
}
