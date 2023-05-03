using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface Command
{
    public abstract void Execute(BaseCharacter player, float value);
}
