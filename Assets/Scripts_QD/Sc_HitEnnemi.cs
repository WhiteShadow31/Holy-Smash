using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_HitEnnemi : MonoBehaviour
{

    public GameObject mob;
    public float impultionForce = 20f;
    //public Vector3 impulseVector = new Vector3(10f, 10f, 0f);

    void Start()
    {

    }

    void Update()
    {

        //Debug.Log(mob.mobDir.y);
    }

    public void OnCollisionEnter(Collision collider)
    {

        collider.rigidbody.AddForce(Vector3.forward * impultionForce, ForceMode.Impulse);
        //GetComponent<Rigidbody>().AddForce(impulseVector, ForceMode.Impulse);
    }
}