using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions _input;

    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputActions();

        _input.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        var move = _input.Player.Movement.ReadValue<Vector2>();

        //for movement along x/y axis
        //transform.Translate(move * Time.deltaTime * 8.0f);

        //for movement along x/z axis
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 3.0f);
    }

}
