// GENERATED AUTOMATICALLY FROM 'Assets/Input/ChallengesInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ChallengesInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ChallengesInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ChallengesInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""032eccc6-5d88-43e7-a890-3219b37d4b05"",
            ""actions"": [
                {
                    ""name"": ""ColourChange"",
                    ""type"": ""Button"",
                    ""id"": ""222e5ab4-b0ef-4888-83a2-0f4585ed1823"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""197ae32f-d133-4a05-a665-a297ccde4cd3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DrivingState"",
                    ""type"": ""Button"",
                    ""id"": ""938772f5-b5fd-4585-98de-79d3f6ca47dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6074a50c-c822-4946-abc9-ae650f3577e7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ColourChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2258e629-16e1-4f73-b154-f6061997d4c2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f032d09e-f239-4138-9fd7-6936025b7727"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1295c24e-1eb7-439e-8a56-24bfd4542cc4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d92c84d4-2788-420f-9848-d374f84f0e2f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c4828c1b-5f81-4319-9a0e-d96d2390e8a9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""62d77a95-76c7-4e85-90bb-d2bb8958fc8d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f3d49266-2c88-4b09-879f-2189a6aa99fe"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DrivingState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drive"",
            ""id"": ""71d4f7af-94d0-46f6-8156-fb6d7ab1f6cc"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0242745e-ff4e-46b9-8abb-d782d58761c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerState"",
                    ""type"": ""Button"",
                    ""id"": ""fe7a7bdc-6613-46da-a8af-ea604d43cd25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Movement"",
                    ""id"": ""79eb0987-6808-40bd-8fb4-561cdfeb1493"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""16ecc9bd-7442-43cf-adb7-b095e6c6c158"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""245bc2fe-a03d-4a6c-af96-6220f8fd9094"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""01726473-db69-467c-a5de-e911b913b82a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""13272dfc-64da-485f-97c1-72b6a425f954"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD Movement"",
                    ""id"": ""51ce8de6-c64d-40de-801b-c88d7f683b41"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a3ee57a7-b9dc-4590-992c-caa29d0e311a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""27b53f1d-47e9-4169-a474-9ce3ae10a410"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bf49468c-ee29-4211-8d8b-c1f20b20a86b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""48f711bf-b82c-4753-9f01-57358c294db2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d07008d2-f783-4279-82c4-4841399dc8cb"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_ColourChange = m_Player.FindAction("ColourChange", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_DrivingState = m_Player.FindAction("DrivingState", throwIfNotFound: true);
        // Drive
        m_Drive = asset.FindActionMap("Drive", throwIfNotFound: true);
        m_Drive_Move = m_Drive.FindAction("Move", throwIfNotFound: true);
        m_Drive_PlayerState = m_Drive.FindAction("PlayerState", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_ColourChange;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_DrivingState;
    public struct PlayerActions
    {
        private @ChallengesInputActions m_Wrapper;
        public PlayerActions(@ChallengesInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ColourChange => m_Wrapper.m_Player_ColourChange;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @DrivingState => m_Wrapper.m_Player_DrivingState;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @ColourChange.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnColourChange;
                @ColourChange.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnColourChange;
                @ColourChange.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnColourChange;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @DrivingState.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrivingState;
                @DrivingState.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrivingState;
                @DrivingState.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrivingState;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ColourChange.started += instance.OnColourChange;
                @ColourChange.performed += instance.OnColourChange;
                @ColourChange.canceled += instance.OnColourChange;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @DrivingState.started += instance.OnDrivingState;
                @DrivingState.performed += instance.OnDrivingState;
                @DrivingState.canceled += instance.OnDrivingState;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drive
    private readonly InputActionMap m_Drive;
    private IDriveActions m_DriveActionsCallbackInterface;
    private readonly InputAction m_Drive_Move;
    private readonly InputAction m_Drive_PlayerState;
    public struct DriveActions
    {
        private @ChallengesInputActions m_Wrapper;
        public DriveActions(@ChallengesInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Drive_Move;
        public InputAction @PlayerState => m_Wrapper.m_Drive_PlayerState;
        public InputActionMap Get() { return m_Wrapper.m_Drive; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DriveActions set) { return set.Get(); }
        public void SetCallbacks(IDriveActions instance)
        {
            if (m_Wrapper.m_DriveActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnMove;
                @PlayerState.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnPlayerState;
                @PlayerState.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnPlayerState;
                @PlayerState.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnPlayerState;
            }
            m_Wrapper.m_DriveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @PlayerState.started += instance.OnPlayerState;
                @PlayerState.performed += instance.OnPlayerState;
                @PlayerState.canceled += instance.OnPlayerState;
            }
        }
    }
    public DriveActions @Drive => new DriveActions(this);
    public interface IPlayerActions
    {
        void OnColourChange(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnDrivingState(InputAction.CallbackContext context);
    }
    public interface IDriveActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPlayerState(InputAction.CallbackContext context);
    }
}
