using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.main.transform.rotation.eulerAngles.x >60 &&
            Camera.main.transform.rotation.eulerAngles.x <=80)
        {
            Vector3 pos = gameObject.transform.position;
            Vector3 move = Camera.main.transform.forward;
            move.y = 0;
            pos = pos + move;
            gameObject.transform.position = Vector3.MoveTowards(transform.position, pos, 5 * Time.deltaTime);
        }
    }

    
}
