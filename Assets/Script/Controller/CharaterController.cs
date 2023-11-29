using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnmoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnmoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
