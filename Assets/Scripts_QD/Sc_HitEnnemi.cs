using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sc_HitEnnemi : MonoBehaviour
{

    //public GameObject mob;
    public float impultionForce = 30f;
    //public Vector3 impulseVector = new Vector3(10f, 10f, 0f);

    public int nbHit = 0;

    //Slow Motion variables
    public float slowMotionTimeScale;

    private float startTimeScale;
    private float startFixedDeltaTime;

    void Start() {

        startTimeScale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update() {

        //var gamepad = Gamepad.current;

        if (nbHit >= 5 /*&&*/  /*Input.GetKeyDown("Space")*/) {

            impultionForce = 50f;
            StartSlowMotion();
        } else {

            StopSlowMotion();
        }
        //Debug.Log(mob.mobDir.y);
    }

    public void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Mob")
        {

            //collider.rigidbody.AddForce(Vector3.forward * impultionForce, ForceMode.Impulse);
            collider.rigidbody.AddForce(Vector3.up * impultionForce, ForceMode.Impulse);
            nbHit++;
        } 
        //GetComponent<Rigidbody>().AddForce(impulseVector, ForceMode.Impulse);
    }

    private void StartSlowMotion() {

        Time.timeScale = slowMotionTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime * slowMotionTimeScale;
    }

    private void StopSlowMotion() {

        Time.timeScale = startTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime;
    }
}