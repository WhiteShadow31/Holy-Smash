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

    }

    public void OnTriggerEnter(Collider collision) {

        StartCoroutine(waitCoroutine());
        scoredetection = true;
        Destroy(collision.gameObject);
    }

    public void OnTriggerExit() {

        scoredetection = false;
    }

    IEnumerator waitCoroutine() {
        
        //yield on a new YieldInstruction that waits for x seconds.
        yield return new WaitForSeconds(3);
    }
}