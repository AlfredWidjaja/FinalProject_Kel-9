using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.D)) {  
            transform.Translate (0.03f, 0f, 0f);
        }  
        if (Input.GetKey (KeyCode.A)) {  
            transform.Translate (-0.03f, 0f, 0f);      
        }  
        if (Input.GetKey (KeyCode.S)) {  
            transform.Translate (0.0f, 0f, -0.03f);      
        }  
        if (Input.GetKey (KeyCode.W)) {  
            transform.Translate (0.0f, 0f, 0.03f);      
        }  
        if (Input.GetKey (KeyCode.Q)){
            transform.Rotate(0, -1, 0, Space.Self);
        }
        if (Input.GetKey (KeyCode.E)){
            transform.Rotate(0, 1, 0, Space.Self);
        }
        
    }

    private void OnCollisionEnter(Collision other) {
        Vector3 move = Camera.main.transform.forward;
        if (other.gameObject.CompareTag("Wall"))
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("Wall")){
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
