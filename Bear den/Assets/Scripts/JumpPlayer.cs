using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    bool flag;
    [SerializeField] Rigidbody rb;
    void Start()
    {
        flag = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && flag == false){
            rb.velocity = new Vector3(0, 3, 0);
            flag = true;
        }
    }

    private void OnCollisionEnter(Collision other) {
        flag = false;
    }
}
