using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderContr : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerbody;
    public CharacterController contr;
    float speed=12f;
    float xRotation=0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X");
        float mouseY=Input.GetAxis("Mouse Y");
        playerbody.Rotate(0,mouseX,0);
        xRotation=xRotation-mouseY;
        transform.localRotation=Quaternion.Euler(xRotation,0,0);
        float vertical=Input.GetAxis("Vertical");
        float horizontal=Input.GetAxis("Horizontal");
        contr.Move(transform.forward*speed*vertical*Time.deltaTime);
        contr.Move(transform.right*speed*horizontal*Time.deltaTime);
    }
}
