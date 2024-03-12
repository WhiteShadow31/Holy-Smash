using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Mob : MonoBehaviour {

    public GameObject Mob;
    public GameObject Target1;
    public GameObject Target2;
    public float VitesseMarche = 10f;

    void Start() {
        
    }

    void Update() {

        Mob.transform.position = Vector3.MoveTowards(Mob.transform.position, Target1.transform.position, VitesseMarche);
    }
}