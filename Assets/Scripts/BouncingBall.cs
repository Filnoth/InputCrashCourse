using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BouncingBall : MonoBehaviour
{
    private BounceInputActions _input;
    private bool _jump = false;
    private float _startTime;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _input = new BounceInputActions();
        _rb = GetComponent<Rigidbody>();
        _input.BouncingBall.Enable();
        _input.BouncingBall.Charge.performed += Charge_performed;
        _input.BouncingBall.Charge.canceled += Charge_canceled;
    }

    private void Charge_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        var chargeTime = context.duration;
        _rb.AddForce(Vector3.up * (20f * (float)(chargeTime)), ForceMode.Impulse);
    }

    private void Charge_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _jump = true;
        _rb.AddForce(Vector3.up * 20f, ForceMode.Impulse);
        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftShiftKey.wasPressedThisFrame)
        {
            Debug.Log("Shift pressed");
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Left mouse clicked");
        }
    }
}
