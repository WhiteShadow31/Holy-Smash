using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_DestroyMob : MonoBehaviour {

    public bool scoredetection = false;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        //Debug.Log(scoredetection);
    }

    public void OnTriggerEnter(Collider collision) {

        scoredetection = true;
        Destroy(collision.gameObject);
        StartCoroutine(waitCoroutine(collision));
    }

    IEnumerator waitCoroutine(Collider collision) {
        
        //yield on a new YieldInstruction that waits for x seconds.
        yield return new WaitForSeconds(2);
        if(collision != null ) {

            Destroy(collision.gameObject);
        }
    }
}