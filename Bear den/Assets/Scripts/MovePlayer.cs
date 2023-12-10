using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    float speed = 3f;
    [SerializeField] Rigidbody _rigidbodyPlayer;

    private void FixedUpdate() {
        float hor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float ver = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(hor, 0, ver);

        if(Input.GetKey(KeyCode.LeftShift)){
            speed = 6f;
        } 
        else{
            speed = 3f;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            _rigidbodyPlayer.AddForce(0, 1, 0);
        }
    }




}
