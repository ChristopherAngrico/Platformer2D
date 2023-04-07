using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public CharacterController characterController;
    public Animator animator;
    void Update()
    {
        RunningAnim();
        JumpAnim();
    }

    private void RunningAnim()
    {
        // if (characterController.absInput > 0)
        // {
        //     animator.SetBool("isRunning", true);
        // }
        // else
        // {
        //     animator.SetBool("isRunning", false);
        // }
        animator.SetFloat("isRunning", characterController.absInput);
    }
    private void JumpAnim(){
        if(characterController.isJumping){
            animator.SetBool("isJumping", true);
        }
        if(!characterController.isJumping){
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", true);
        }
        if(characterController.isGrounded){
            animator.SetBool("isFalling", false);
        }
    }
}
