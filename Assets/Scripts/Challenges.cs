using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Challenges : MonoBehaviour
{
    private ChallengesInputActions _input;
    private Material _mat;

    // Start is called before the first frame update
    void Start()
    {
        _input = new ChallengesInputActions();
        _input.Player.Enable();
        _input.Player.ColourChange.performed += ColourChange_performed;
        _input.Player.DrivingState.performed += DrivingState_performed;
        _input.Drive.PlayerState.performed += PlayerState_performed;
        
        _mat = GetComponent<MeshRenderer>().material;
    }

    private void PlayerState_performed(InputAction.CallbackContext obj)
    {
        _input.Drive.Disable();
        _input.Player.Enable();
    }

    private void DrivingState_performed(InputAction.CallbackContext obj)
    {
        _input.Player.Disable();
        _input.Drive.Enable();
    }

    private void ColourChange_performed(InputAction.CallbackContext obj)
    {
        if (_mat != null)
        _mat.color = Random.ColorHSV();
    }

        // Update is called once per frame
    void Update()
    {
        var rotateDirection = _input.Player.Rotate.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * 30f, rotateDirection);

        DriveMovement();
    }

    void DriveMovement()
    {
        var move = _input.Drive.Move.ReadValue<Vector2>();

        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 5.0f); 
    }

}
