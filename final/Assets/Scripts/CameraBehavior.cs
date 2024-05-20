using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

//Creating an offset position for the camera + finding and storing player capsule's position + updating cam position and rotation to follwo player

    //declares vector3 variable to store distance between main cam and player capsule 
    public Vector3 CamOffset = new Vector3(0f , 1.2f, -2.6f);

    //creates variable to hold player capsule's Transform info 
    private Transform _target;

    // Uses GameObject.Find to locate the capsule by name and retrieve Transform property from scene
    void Start()
    {
     //
    _target = GameObject.Find("Player").transform;
    }

    //setting camera position for every frame
    void LateUpdate()
    {
        //calculates and returns a relative position in world space
        this.transform.position = _target.TransformPoint(CamOffset);
        // updates the capsule's rotation at every frame. 
        this.transform.LookAt(_target);
    }
}
