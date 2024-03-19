using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class SC_Mob : MonoBehaviour {

    public GameObject target1;
    public GameObject target2;
    public float vitesseMarche = 10f;
    protected NavMeshAgent m_agent;



    private void Awake() {

        m_agent = GetComponent<NavMeshAgent>();
        m_agent.speed = vitesseMarche;
    }

    void Start() {
        
    }

    void Update() {

        //this.transform.position = Vector3.MoveTowards(this.transform.position, target1.transform.position, vitesseMarche * Time.deltaTime);
        m_agent.destination = target1.transform.position;
    }
}