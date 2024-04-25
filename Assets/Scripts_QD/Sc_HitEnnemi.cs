using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_HitEnnemi : MonoBehaviour {

    public SC_Mob mob;
    public float impultionForce = 20f;

    void Start() {

    }

    void Update() {

        Debug.Log(mob.mobDir.y);
    }

    public void OnCollisionEnter() {

        //collider.Rigidbody.AddForce(Vector3.forward * impultionForce, FoceMode.Impulse);
    }
}