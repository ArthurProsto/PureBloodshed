using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smooth;
    private void Start()
    {
        offset = transform.position - target.position;
    }


    private void LateUpdate()
    {
      
        Vector2 moveVec = Vector2.Lerp(transform.position, target.position + offset, smooth  * Time.deltaTime);
        transform.position = moveVec;
    }
}
