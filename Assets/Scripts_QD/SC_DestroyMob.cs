using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_DestroyMob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision) {

        StartCoroutine(waitCoroutine());
        Destroy(collision.gameObject);
    }

    IEnumerator waitCoroutine()
    {
        
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
    }
}