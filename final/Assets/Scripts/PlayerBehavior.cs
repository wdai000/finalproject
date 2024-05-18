using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // 1
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    // 2
    private float _vInput;
    private float _hInput;

    // Update is called once per frame
    void Update()
    {
    // 3
    _vInput = Input.GetAxis("Vertical") * MoveSpeed;
    // 4
    _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
    // 5
    this.transform.Translate(Vector3.forward * _vInput *
    Time.deltaTime);
    // 6
    this.transform.Rotate(Vector3.up * _hInput *
    Time.deltaTime);
    }
}
