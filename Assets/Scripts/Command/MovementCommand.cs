using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementCommand : Command
{

    public string state = "Movement";

    public void Execute(BaseCharacter player, float value)
    {
        //float movementValue = context.ReadValue<float>();
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(value * Time.deltaTime * player.Speed, rb.velocity.y);
    }
}
