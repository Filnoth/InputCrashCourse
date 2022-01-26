using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private JoystickInputActions _input;
    private Slider _slider;
    private bool _isCharging;
    [SerializeField]
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _input = new JoystickInputActions();
        _input.ProgressBar.Enable();
        _slider = GetComponent<Slider>();

        _input.ProgressBar.Charge.started += Charge_started;
        _input.ProgressBar.Charge.canceled += Charge_canceled;
    }

    private void Charge_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _isCharging = false;
    }

    private void Charge_started(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _isCharging = true;
        StartCoroutine(ChargeRoutine());
    }

    private void Update()
    {
        
        _text.text = ("Charge: " + Mathf.Round(_slider.value * 100) + "%");
    }

    IEnumerator ChargeRoutine()
    {
        while(_isCharging == true)
        {
            _slider.value += (Time.deltaTime * 1f) / 3f;

            yield return null;
        }

        while (_slider.value > 0 && _isCharging == false)
        {
            _slider.value -= (Time.deltaTime * 1f) / 5f;
            yield return null;
        }
        
    }
}
