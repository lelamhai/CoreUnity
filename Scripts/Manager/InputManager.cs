using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<MonoBehaviour>
{
    public Vector2 MovementPos { get; private set; }

    private void Update()
    {
        GetMovementPos();
    }

    protected virtual void GetMovementPos()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        var z = 0;

        MovementPos = new Vector3(x, y, z);
    }
}
