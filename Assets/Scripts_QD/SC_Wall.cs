using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Wall : MonoBehaviour {

    public GameObject childToActivate;

    void Start() {

        childToActivate = transform.GetChild(0).gameObject;
    }

    void Update() {

        changeDifficulty();
    }

    public void changeDifficulty() {

    }
}