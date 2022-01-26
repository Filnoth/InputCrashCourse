// GENERATED AUTOMATICALLY FROM 'Assets/Input/JoystickInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @JoystickInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @JoystickInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""JoystickInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""9d4b96a9-4f3b-46f2-8b68-a0c6da47dbc2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""6614ca93-a9ed-467d-8dcf-103e27d8f85b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1cafbd4e-8879-4f74-80d0-3cf6490b9e4d"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ProgressBar"",
            ""id"": ""84a4b899-7fe0-4a1d-842f-f71e20e0d916"",
            ""actions"": [
                {
                    ""name"": ""Charge"",
                    ""type"": ""Button"",
                    ""id"": ""5b1ad4c0-5c17-44e9-8116-69299b1bf991"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""31a3ac9d-e562-42d6-99b5-8f616bce7610"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Charge"",
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
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        // ProgressBar
        m_ProgressBar = asset.FindActionMap("ProgressBar", throwIfNotFound: true);
        m_ProgressBar_Charge = m_ProgressBar.FindAction("Charge", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @JoystickInputActions m_Wrapper;
        public PlayerActions(@JoystickInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // ProgressBar
    private readonly InputActionMap m_ProgressBar;
    private IProgressBarActions m_ProgressBarActionsCallbackInterface;
    private readonly InputAction m_ProgressBar_Charge;
    public struct ProgressBarActions
    {
        private @JoystickInputActions m_Wrapper;
        public ProgressBarActions(@JoystickInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Charge => m_Wrapper.m_ProgressBar_Charge;
        public InputActionMap Get() { return m_Wrapper.m_ProgressBar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ProgressBarActions set) { return set.Get(); }
        public void SetCallbacks(IProgressBarActions instance)
        {
            if (m_Wrapper.m_ProgressBarActionsCallbackInterface != null)
            {
                @Charge.started -= m_Wrapper.m_ProgressBarActionsCallbackInterface.OnCharge;
                @Charge.performed -= m_Wrapper.m_ProgressBarActionsCallbackInterface.OnCharge;
                @Charge.canceled -= m_Wrapper.m_ProgressBarActionsCallbackInterface.OnCharge;
            }
            m_Wrapper.m_ProgressBarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Charge.started += instance.OnCharge;
                @Charge.performed += instance.OnCharge;
                @Charge.canceled += instance.OnCharge;
            }
        }
    }
    public ProgressBarActions @ProgressBar => new ProgressBarActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IProgressBarActions
    {
        void OnCharge(InputAction.CallbackContext context);
    }
}
