using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class SC_Mob : MonoBehaviour {

    //Ref aux target sur la sc�ne
    public GameObject target1;
    //public GameObject target2;

    //Vitesse de d�placement du mob
    public float vitesseMarche = 10f;

    protected NavMeshAgent m_agent;

    //public Vector3 mobDir;

    //private void Awake() {

    //    m_agent = GetComponent<NavMeshAgent>();
    //    m_agent.speed = vitesseMarche;
    //}

    void Start() {
        
    }

    void Update() {
        
        //D�placement du mob vers le premier target
        //this.transform.position = Vector3.MoveTowards(this.transform.position, target1.transform.position, vitesseMarche * Time.deltaTime);
        
        //m_agent.destination = target1.transform.position;

        //Calcul de la direction du mob pour r�cup�rer son forward
        //Vector3 mobDirection = target1.transform.position - transform.position;
        //mobDir = mobDirection;
        //Debug.Log(mobDirection.y);
        //Debug.Log(GetComponent<Rigidbody>().useGravity);
    }

    //public void OnCollisionEnter(Collision collision) {

    //    if (collision.gameObject.tag == "Destroyer") {

    //        GetComponent<Rigidbody>().useGravity = false;
    //        Invoke("SetOnGravity", 5f);
    //    }
    //}

    //public void SetOnGravity() {

    //    GetComponent<Rigidbody>().useGravity = true;
    //}
}