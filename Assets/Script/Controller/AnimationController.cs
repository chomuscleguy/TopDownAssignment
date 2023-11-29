using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    PlayerInputController controller;

    [SerializeField] private Animator anim;
    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
    }
    void Start()
    {
        controller.OnmoveEvent += Animstate;
    }
    void Animstate(Vector2 dir)
    {
        anim.SetBool("Run", dir.magnitude > 0f);
    }

}
