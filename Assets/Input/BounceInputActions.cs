// GENERATED AUTOMATICALLY FROM 'Assets/Input/BounceInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BounceInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BounceInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BounceInputActions"",
    ""maps"": [
        {
            ""name"": ""BouncingBall"",
            ""id"": ""22f85bce-0393-4680-b64a-74e8efb45901"",
            ""actions"": [
                {
                    ""name"": ""Charge"",
                    ""type"": ""Button"",
                    ""id"": ""842b5da5-b123-4028-83c2-c53c3c88ce5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a58635a8-a9c1-467e-bbc6-32a3c178709d"",
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
        // BouncingBall
        m_BouncingBall = asset.FindActionMap("BouncingBall", throwIfNotFound: true);
        m_BouncingBall_Charge = m_BouncingBall.FindAction("Charge", throwIfNotFound: true);
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

    // BouncingBall
    private readonly InputActionMap m_BouncingBall;
    private IBouncingBallActions m_BouncingBallActionsCallbackInterface;
    private readonly InputAction m_BouncingBall_Charge;
    public struct BouncingBallActions
    {
        private @BounceInputActions m_Wrapper;
        public BouncingBallActions(@BounceInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Charge => m_Wrapper.m_BouncingBall_Charge;
        public InputActionMap Get() { return m_Wrapper.m_BouncingBall; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BouncingBallActions set) { return set.Get(); }
        public void SetCallbacks(IBouncingBallActions instance)
        {
            if (m_Wrapper.m_BouncingBallActionsCallbackInterface != null)
            {
                @Charge.started -= m_Wrapper.m_BouncingBallActionsCallbackInterface.OnCharge;
                @Charge.performed -= m_Wrapper.m_BouncingBallActionsCallbackInterface.OnCharge;
                @Charge.canceled -= m_Wrapper.m_BouncingBallActionsCallbackInterface.OnCharge;
            }
            m_Wrapper.m_BouncingBallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Charge.started += instance.OnCharge;
                @Charge.performed += instance.OnCharge;
                @Charge.canceled += instance.OnCharge;
            }
        }
    }
    public BouncingBallActions @BouncingBall => new BouncingBallActions(this);
    public interface IBouncingBallActions
    {
        void OnCharge(InputAction.CallbackContext context);
    }
}
