//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scripts/Player/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""MovementPlayer"",
            ""id"": ""a6e46428-a0ef-4770-b79f-ad3c93549021"",
            ""actions"": [
                {
                    ""name"": ""Translate"",
                    ""type"": ""Value"",
                    ""id"": ""26092173-8d6a-4f1e-9e60-674f662e435f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""eb093634-4146-4da7-9882-10adc177fe91"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e52dc773-c09a-48c9-ba3b-127821d0f903"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ff3ea04a-0aa6-4ce1-b613-e1fa04a7318a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Recording"",
            ""id"": ""f8da6e35-53f4-4659-a334-7368b5965240"",
            ""actions"": [
                {
                    ""name"": ""ToggleRecording"",
                    ""type"": ""Value"",
                    ""id"": ""e0fddee7-8360-4491-a6d0-7692646bdc2e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""02c1b589-e2f9-456d-95ee-5073318863e9"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleRecording"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GhostSpawn"",
            ""id"": ""ed7ee43e-069c-4125-9256-ba7ab78806f4"",
            ""actions"": [
                {
                    ""name"": ""Spawn"",
                    ""type"": ""Button"",
                    ""id"": ""8897afa0-bfd8-47ef-99ad-0da56ec9b07c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""473da649-33fd-4d02-89a5-09d2d3c0b334"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MovementPlayer
        m_MovementPlayer = asset.FindActionMap("MovementPlayer", throwIfNotFound: true);
        m_MovementPlayer_Translate = m_MovementPlayer.FindAction("Translate", throwIfNotFound: true);
        // Recording
        m_Recording = asset.FindActionMap("Recording", throwIfNotFound: true);
        m_Recording_ToggleRecording = m_Recording.FindAction("ToggleRecording", throwIfNotFound: true);
        // GhostSpawn
        m_GhostSpawn = asset.FindActionMap("GhostSpawn", throwIfNotFound: true);
        m_GhostSpawn_Spawn = m_GhostSpawn.FindAction("Spawn", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MovementPlayer
    private readonly InputActionMap m_MovementPlayer;
    private List<IMovementPlayerActions> m_MovementPlayerActionsCallbackInterfaces = new List<IMovementPlayerActions>();
    private readonly InputAction m_MovementPlayer_Translate;
    public struct MovementPlayerActions
    {
        private @InputActions m_Wrapper;
        public MovementPlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Translate => m_Wrapper.m_MovementPlayer_Translate;
        public InputActionMap Get() { return m_Wrapper.m_MovementPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementPlayerActions set) { return set.Get(); }
        public void AddCallbacks(IMovementPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementPlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementPlayerActionsCallbackInterfaces.Add(instance);
            @Translate.started += instance.OnTranslate;
            @Translate.performed += instance.OnTranslate;
            @Translate.canceled += instance.OnTranslate;
        }

        private void UnregisterCallbacks(IMovementPlayerActions instance)
        {
            @Translate.started -= instance.OnTranslate;
            @Translate.performed -= instance.OnTranslate;
            @Translate.canceled -= instance.OnTranslate;
        }

        public void RemoveCallbacks(IMovementPlayerActions instance)
        {
            if (m_Wrapper.m_MovementPlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementPlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementPlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementPlayerActions @MovementPlayer => new MovementPlayerActions(this);

    // Recording
    private readonly InputActionMap m_Recording;
    private List<IRecordingActions> m_RecordingActionsCallbackInterfaces = new List<IRecordingActions>();
    private readonly InputAction m_Recording_ToggleRecording;
    public struct RecordingActions
    {
        private @InputActions m_Wrapper;
        public RecordingActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleRecording => m_Wrapper.m_Recording_ToggleRecording;
        public InputActionMap Get() { return m_Wrapper.m_Recording; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RecordingActions set) { return set.Get(); }
        public void AddCallbacks(IRecordingActions instance)
        {
            if (instance == null || m_Wrapper.m_RecordingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RecordingActionsCallbackInterfaces.Add(instance);
            @ToggleRecording.started += instance.OnToggleRecording;
            @ToggleRecording.performed += instance.OnToggleRecording;
            @ToggleRecording.canceled += instance.OnToggleRecording;
        }

        private void UnregisterCallbacks(IRecordingActions instance)
        {
            @ToggleRecording.started -= instance.OnToggleRecording;
            @ToggleRecording.performed -= instance.OnToggleRecording;
            @ToggleRecording.canceled -= instance.OnToggleRecording;
        }

        public void RemoveCallbacks(IRecordingActions instance)
        {
            if (m_Wrapper.m_RecordingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRecordingActions instance)
        {
            foreach (var item in m_Wrapper.m_RecordingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RecordingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RecordingActions @Recording => new RecordingActions(this);

    // GhostSpawn
    private readonly InputActionMap m_GhostSpawn;
    private List<IGhostSpawnActions> m_GhostSpawnActionsCallbackInterfaces = new List<IGhostSpawnActions>();
    private readonly InputAction m_GhostSpawn_Spawn;
    public struct GhostSpawnActions
    {
        private @InputActions m_Wrapper;
        public GhostSpawnActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Spawn => m_Wrapper.m_GhostSpawn_Spawn;
        public InputActionMap Get() { return m_Wrapper.m_GhostSpawn; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GhostSpawnActions set) { return set.Get(); }
        public void AddCallbacks(IGhostSpawnActions instance)
        {
            if (instance == null || m_Wrapper.m_GhostSpawnActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GhostSpawnActionsCallbackInterfaces.Add(instance);
            @Spawn.started += instance.OnSpawn;
            @Spawn.performed += instance.OnSpawn;
            @Spawn.canceled += instance.OnSpawn;
        }

        private void UnregisterCallbacks(IGhostSpawnActions instance)
        {
            @Spawn.started -= instance.OnSpawn;
            @Spawn.performed -= instance.OnSpawn;
            @Spawn.canceled -= instance.OnSpawn;
        }

        public void RemoveCallbacks(IGhostSpawnActions instance)
        {
            if (m_Wrapper.m_GhostSpawnActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGhostSpawnActions instance)
        {
            foreach (var item in m_Wrapper.m_GhostSpawnActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GhostSpawnActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GhostSpawnActions @GhostSpawn => new GhostSpawnActions(this);
    public interface IMovementPlayerActions
    {
        void OnTranslate(InputAction.CallbackContext context);
    }
    public interface IRecordingActions
    {
        void OnToggleRecording(InputAction.CallbackContext context);
    }
    public interface IGhostSpawnActions
    {
        void OnSpawn(InputAction.CallbackContext context);
    }
}
