using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour {

    public float minX = -60f;
    public float maxX = 60f;

    public float interactDistance = 2.5f;

    public float sensitivityX = 15f;
    public float sensitivityY = 15f;

    public Camera cam;

    float rotX;
    float rotY;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        rotX += Input.GetAxis("Mouse Y") * sensitivityX;
        rotY += Input.GetAxis("Mouse X") * sensitivityY;



        CheckForInteract();




        rotX = Mathf.Clamp(rotX, minX, maxX);
        transform.localRotation = Quaternion.AngleAxis(rotY, this.transform.up);



        cam.transform.localRotation = Quaternion.AngleAxis(-rotX, Vector3.right);

        if (Input.GetKey(KeyCode.Escape)){
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
	}


    void CheckForInteract(){

        RaycastHit hit;
        var ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Physics.Raycast(ray, out hit,interactDistance))
        {
            Interactable interHit = hit.transform.gameObject.GetComponent<Interactable>();


            if (interHit != null){
                InteractTextUI.instance.SetText(interHit.HoverText());
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interHit.Interact(this.gameObject);
                }
            }else{
                InteractTextUI.instance.SetText(" ");
            }
            // Do something with the object that was hit by the raycast.
        }else{
            InteractTextUI.instance.SetText(" ");
        }
    }
}
