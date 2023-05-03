using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordingComponent : MonoBehaviour
{
    private InputManager inputManager;
    private bool isRecording;
    private float recordingTime;
    private Vector2 recordingPosition;
    private SortedList <float, TypeOfCommand> mapCommands = new SortedList<float, TypeOfCommand>();

    public bool IsRecording { get => isRecording;}
    public Vector2 RecordingPosition { get => recordingPosition; }
    public SortedList<float, TypeOfCommand> MapCommands { get => mapCommands; }

    private void OnEnable()
    {
        if (inputManager == null) inputManager = GetComponent<InputManager>();
        inputManager.onToggleRecording += ToggleRecording;
    }

    private void ToggleRecording()
    {
        isRecording = !isRecording;
        if (isRecording)
        {
            recordingPosition = transform.position;
            StartCoroutine(TimerRecording());
        }
        else
        {
            recordingTime = Time.time;
        }
    }

    public void AddCommand(TypeOfCommand command)
    {
        mapCommands.Add(recordingTime, command);
        Debug.Log("Command add " + mapCommands.Count);
    }

    private IEnumerator TimerRecording()
    {
        while (isRecording)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            recordingTime += Time.deltaTime;
        }
    }

}
