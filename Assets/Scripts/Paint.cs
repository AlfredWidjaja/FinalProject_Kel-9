using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(time());
    }
    IEnumerator time(){
        while(true)
        {
            transform.Translate(0, 0, 0.1f);
            yield return new WaitForSeconds(1);
            transform.Translate(0, 0, -0.1f);
            yield return new WaitForSeconds(1);
            transform.Translate(-0.6f, 0.3f, 0.5f);
            yield return new WaitForSeconds(1);
            transform.Translate(0, 0.1f, 0.1f);
            yield return new WaitForSeconds(1);
            transform.Translate(0, -0.1f, -0.1f);
            yield return new WaitForSeconds(1);
            transform.Translate(0.6f, -0.3f, -0.5f);
            yield return new WaitForSeconds(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
