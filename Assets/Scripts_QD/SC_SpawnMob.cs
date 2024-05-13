using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SpawnMob : MonoBehaviour {

    public GameObject mob;
    public GameObject plateform;
    public float speedPlateform = 0.5f;

    public GameObject batte;

    void Start() {
        
    }
    void Update() {
        
    }

    public void spawnMob() {

        //plateform.transform.Translate(new Vector3(8.25f, -2.1f, 0) * speedPlateform * Time.deltaTime);
        //mob.transform.position = new Vector3(plateform.transform.position.x, plateform.transform.position.y, plateform.transform.position.z + 0.2f);
        Instantiate(mob, new Vector3(plateform.transform.position.x, plateform.transform.position.y + 1.5f, plateform.transform.position.z), Quaternion.identity);
        //Invoke("mouvingPlateform", 1f);
    }

    //public void mouvingPlateform() {

    //    plateform.transform.Translate(new Vector3(8.25f, -0.1f, 0) * speedPlateform * Time.deltaTime);
    //}

    public void spawnBatte() {

        //Destroy(batte);
        Instantiate(batte, new Vector3(6, 0.5f, -2), Quaternion.identity);
    }
}