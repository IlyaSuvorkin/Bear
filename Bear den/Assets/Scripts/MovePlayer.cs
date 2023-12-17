using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{           
public float speed;
bool move;
[SerializeField] Transform player;
[SerializeField] Animator animator;

[SerializeField] UnityEngine.Vector3 direction;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            animator.SetBool("Walk", true);
            move = true;
            animator.SetBool("BackRun", false);
        }

        if(move){
            UnityEngine.Vector3 playerPosition = player.position + player.forward * Time.deltaTime * speed;
            player.position = playerPosition;
        }
        if(Input.GetKeyUp(KeyCode.W)){
            animator.SetBool("Walk", false);
            animator.SetBool("Run", false);
            move = false;
        }
        if((Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))){
            player.Rotate(0, -1.25f, 0);
        }

        if((Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))){
            player.Rotate(0, 1.25f, 0);
        }

        if(Input.GetKey(KeyCode.LeftShift) &&  Input.GetKey(KeyCode.W)){
            animator.SetBool("Run", true);
        } 
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)){
            speed = 6f;
        } 
        else{
            speed = 2.25f;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            animator.SetBool("Run", false);
        } 
        
        if(Input.GetKeyDown(KeyCode.S)){
            animator.SetBool("BackRun", true);
            animator.SetBool("Run", false);
            animator.SetBool("Walk", false);
        }
        if(Input.GetKey(KeyCode.S) ){
            transform.Translate(-player.forward * Time.deltaTime * speed);
        }
        
        if(Input.GetKeyUp(KeyCode.S)){
            animator.SetBool("BackRun", false);
        }
    }
}
