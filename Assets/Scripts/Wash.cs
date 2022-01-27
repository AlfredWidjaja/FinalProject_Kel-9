using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(time());
    }

    IEnumerator time(){
        while(true)
        {
            transform.Translate(0.1f, 1.2f, 0);
            yield return new WaitForSeconds(2);
            transform.Translate(-0.1f, -1.2f, 0);
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
