using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Mummy : MonoBehaviour {

    private Rigidbody[] _ragdollRigidbodies;

    public bool hitByBatte = false;

    // Start is called before the first frame update
    void Awake() {

        _ragdollRigidbodies = GetComponentsInChildren<Rigidbody>();
        DisableRagdoll();
    }

    // Update is called once per frame
    void Update() {


    }
    private void DisableRagdoll() {

        foreach(var rigidbody in _ragdollRigidbodies) {

            rigidbody.isKinematic = true;
        }
    }

    private void EnableRagdoll() {

        foreach (var rigidbody in _ragdollRigidbodies)
        {

            rigidbody.isKinematic = false;
        }
    }
    public void OnCollisionEnter(Collision collider) {

        if (collider.gameObject.tag == "Batte") {

            EnableRagdoll();
        }
    }
}