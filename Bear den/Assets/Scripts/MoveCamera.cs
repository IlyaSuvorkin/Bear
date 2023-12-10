using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform _transPosPlayer;
    

    private void Update() {
        transform.position = _transPosPlayer.position;
    }
}
