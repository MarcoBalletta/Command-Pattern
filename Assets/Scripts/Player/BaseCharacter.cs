using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float jumpForce;
    protected Rigidbody2D rb;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public float Speed { get => speed;}
    public float JumpForce { get => jumpForce; }
}
