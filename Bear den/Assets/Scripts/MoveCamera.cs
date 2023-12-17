using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MoveCamera 
: MonoBehaviour
{
    [SerializeField]  Transform player;
    float smoothTime = 0.09f;
    private UnityEngine.Vector3 vel;
    [SerializeField] MovePlayer movePlayer;
    private void Update()
    {   
        // if((Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))){
        //     transform.forward = UnityEngine.Vector3.SmoothDamp(transform.forward, player.forward, ref vel, 0.018f);
        //     transform.position = UnityEngine.Vector3.SmoothDamp(transform.position, player.position, ref vel, 0.018f);
        // }
        // else{
            transform.forward = UnityEngine.Vector3.SmoothDamp(transform.forward, player.forward, ref vel, smoothTime); 

            if(Input.GetKey(KeyCode.W)){
                transform.position = UnityEngine.Vector3.SmoothDamp(transform.position, player.position, ref vel, smoothTime); 
            }
            else if(Input.GetKey(KeyCode.S)){
                transform.position = transform.position - transform.forward * Time.deltaTime * 2.25f;
            }
    }
}
