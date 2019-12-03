using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class CrossSectionPlane : MonoBehaviour
{
    public Material mat1, mat2;
    public float KeyMoveSpeed = 1;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * KeyMoveSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * KeyMoveSpeed * Time.deltaTime;
        }
        mat1.SetVector("_PlanePosition", transform.position);
        mat1.SetVector("_PlaneNormal", transform.forward);
        mat2.SetVector("_PlanePosition", transform.position);
        mat2.SetVector("_PlaneNormal", transform.forward);
    }
}
