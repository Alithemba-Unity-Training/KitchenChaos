using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerAnimator : MonoBehaviour
{

    private const string IS_WALKING = "IsWalking";

    [SerializeField] private Player player;


    private Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());

    }
}
