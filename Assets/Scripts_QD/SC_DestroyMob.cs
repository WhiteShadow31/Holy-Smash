using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_DestroyMob : MonoBehaviour {

    public bool scoredetection = false;

    public GameObject spawnMob;

    private bool isEnterOnce = false;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        //Debug.Log(scoredetection);
    }

    public void OnTriggerEnter(Collider collision) {

        if(collision.gameObject.tag != "Mob" && collision.gameObject.tag != "Batte") {

            collision.transform.position = new Vector3(0, 0, 0);

        } else {

            if(collision.gameObject.tag == "Mob" && isEnterOnce == false)
            {
                spawnMob.GetComponent<SC_Spawner>().nbMob--;
                isEnterOnce = true;
                StartCoroutine(waitCoroutine(collision));
            }

            if (collision.gameObject.tag == "Batte")
            {
                Destroy(collision.gameObject);
            }
        }

        scoredetection = true;
    }

    IEnumerator waitCoroutine(Collider collision) {
        
        //yield on a new YieldInstruction that waits for x seconds.
        if(collision != null ) {

            collision.transform.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
            collision.gameObject.transform.GetChild(1).GetComponent<ParticleSystem>().Play();


            yield return new WaitForSeconds(2);

            isEnterOnce = false;
            Destroy(collision.gameObject);
        }
    }
}