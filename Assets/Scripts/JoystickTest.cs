using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickTest : MonoBehaviour
{

    private JoystickInputActions _input;
    // Start is called before the first frame update
    void Start()
    {
        _input = new JoystickInputActions();
        _input.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        var move = _input.Player.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, move.y, 0) * Time.deltaTime * 3.0f);
    }
}
