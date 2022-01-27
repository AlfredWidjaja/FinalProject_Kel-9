using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NgelirNglorod : MonoBehaviour
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
            yield return new WaitForSeconds(2);
            transform.Translate(2.1f, 0, -1f);
            transform.Rotate(0, 45, 0);
            yield return new WaitForSeconds(1);
            transform.Translate(-0.2f, 1.4f, 0);
            yield return new WaitForSeconds(2);
            transform.Translate(0.2f, -1.4f, 0);
            yield return new WaitForSeconds(1);
            transform.Rotate(0,-45, 0);
            transform.Translate(-2.1f, 0, 1f);
            yield return new WaitForSeconds(2);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
