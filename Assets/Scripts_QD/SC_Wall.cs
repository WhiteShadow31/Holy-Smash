using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SC_Wall : MonoBehaviour {

    public GameObject child0;
    public GameObject child1;
    public GameObject child2;
    public GameObject child3;

    public int i;
    public int d;

    public int multiplypts = 1;

    public TMP_Text scoreText;
    public int score;

    public int nbSetActive = 0;

    void Start() {

        child0 = transform.GetChild(0).gameObject;
        child1 = transform.GetChild(1).gameObject;
        child2 = transform.GetChild(2).gameObject;
        child3 = transform.GetChild(3).gameObject;
        i = 0;
        d = 0;
        scoreText.text = "Score : " + score;
    }

    void Update() {

        scoreText.text = "Score : " + score;

        //=====================================================================================//

        if (child0.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            changePhase();
            score += 100 * multiplypts;
            child0.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }

        //=====================================================================================//

        if (child1.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child1.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            child1.transform.GetChild(0).GetComponent<CapsuleCollider>().enabled = false;

            changePhase();
            score += 200 * multiplypts;
            child1.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }
        if (child1.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child1.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = false;
            child1.transform.GetChild(1).GetComponent<CapsuleCollider>().enabled = false;

            changePhase();
            score += 200 * multiplypts;
            child1.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }

        //=====================================================================================//

        if (child2.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child2.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            child2.transform.GetChild(0).GetComponent<CapsuleCollider>().enabled = false;

            changePhase();
            score += 300 * multiplypts;
            child2.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }
        if (child2.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child2.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = false;
            child2.transform.GetChild(1).GetComponent<CapsuleCollider>().enabled = false;

            changePhase();
            score += 300 * multiplypts;
            child2.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }
        if (child2.transform.GetChild(2).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child2.transform.GetChild(2).GetComponent<MeshRenderer>().enabled = false;
            child2.transform.GetChild(2).GetComponent<CapsuleCollider>().enabled = false;

            changePhase();
            score += 300 * multiplypts;
            child2.transform.GetChild(2).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }

        //=====================================================================================//

        if (child3.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            score += 400 * multiplypts;
            child3.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
        }

        //Debug.Log(nbSetActive);
    }

    public void SetObjectState(GameObject obj, bool state) {

        foreach(MeshRenderer renderer in obj.GetComponentsInChildren<MeshRenderer>()) {

            renderer.enabled = state;
        }

        foreach (CapsuleCollider collider in obj.GetComponentsInChildren<CapsuleCollider>())
        {

            collider.enabled = state;
        }
    }

    public void changePhase() {

        switch (i) {

            case 0:

                SetObjectState(child0, true);
                SetObjectState(child1, false);
                SetObjectState(child2, false);
                SetObjectState(child3, false);

                nbSetActive++;

                if (nbSetActive >= 0) {

                    i++;
                    nbSetActive = 0;
                }
                break;

            case 1:

                if (nbSetActive <= 0)
                {

                    SetObjectState(child0, false);
                    SetObjectState(child1, true);
                    SetObjectState(child2, false);
                    SetObjectState(child3, false);
                }

                nbSetActive++;

                if (nbSetActive >= 3)
                {

                    i++;
                    nbSetActive = 0;
                }
                break;

            case 2:

                if (nbSetActive <= 0)
                {

                    SetObjectState(child0, false);
                    SetObjectState(child1, false);
                    SetObjectState(child2, true);
                    SetObjectState(child3, false);
                }

                nbSetActive++;

                if (nbSetActive >= 6)
                {

                    //Invoke("iIncrementation", 2.5f);
                    i++;
                    nbSetActive = 0;
                }
                break;

            case 3:

                SetObjectState(child0, false);
                SetObjectState(child1, false);
                SetObjectState(child2, false);
                SetObjectState(child3, true);

                break;
        }
    }

    public void changeDistance() {

        if (d > 3) {

            d = 0;
        } else {

            d ++;
        }

        switch (d) {

            case 0:
                this.transform.position = new Vector3(20, this.transform.position.y, this.transform.position.z);
                multiplypts = 1;
                break;

            case 1:
                this.transform.position = new Vector3(this.transform.position.x + 10, this.transform.position.y, this.transform.position.z);
                multiplypts = 2;
                break;

            case 2:
                this.transform.position = new Vector3(this.transform.position.x + 10, this.transform.position.y, this.transform.position.z);
                multiplypts = 3;
                break;

            case 3:
                this.transform.position = new Vector3(this.transform.position.x + 10, this.transform.position.y, this.transform.position.z);
                multiplypts = 4;
                break;
        }
    }

    //public void Incrementationi() {

    //    i++;
    //}

    public void ResetAll() {

        i = 0;
        d = 0;
        score = 0;
        nbSetActive = 0;
        multiplypts = 1;

        //=====================================================================================//

        //child1.transform.GetChild(0).gameObject.SetActive(true);
        //child1.transform.GetChild(1).gameObject.SetActive(true);

        //=====================================================================================//

        //child2.transform.GetChild(0).gameObject.SetActive(true);
        //child2.transform.GetChild(1).gameObject.SetActive(true);
        //child2.transform.GetChild(2).gameObject.SetActive(true);

        //=====================================================================================//

        changePhase();
    }
}