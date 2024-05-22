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
            score += 100;
            child0.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }

        //=====================================================================================//

        if (child1.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child1.transform.GetChild(0).gameObject.SetActive(false);
            changePhase();
            score += 200;
            child1.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }
        if (child1.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child1.transform.GetChild(1).gameObject.SetActive(false);
            changePhase();
            score += 200;
            child1.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }

        //=====================================================================================//

        if (child2.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child2.transform.GetChild(0).gameObject.SetActive(false);
            changePhase();
            score += 300;
            child2.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }
        if (child2.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child2.transform.GetChild(1).gameObject.SetActive(false);
            changePhase();
            score += 300;
            child2.transform.GetChild(1).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }
        if (child2.transform.GetChild(2).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            child2.transform.GetChild(2).gameObject.SetActive(false);
            changePhase();
            score += 300;
            child2.transform.GetChild(2).GetComponent<SC_DestroyMob>().scoredetection = false;
            changePhase();
        }

        //=====================================================================================//

        if (child3.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection == true)
        {

            score += 400;
            child3.transform.GetChild(0).GetComponent<SC_DestroyMob>().scoredetection = false;
        }

        //Debug.Log(nbSetActive);
    }

    public void changePhase() {

        switch (i) {

            case 0:
                child0.SetActive(true);
                child1.SetActive(false);
                child2.SetActive(false);
                child3.SetActive(false);

                nbSetActive++;

                if (nbSetActive >= 0) {

                    i++;
                    nbSetActive = 0;
                }
                break;

            case 1:

                child0.SetActive(false);
                child1.SetActive(true);
                child2.SetActive(false);
                child3.SetActive(false);

                nbSetActive++;

                if (nbSetActive >= 3)
                {

                    i++;
                    nbSetActive = 0;
                }
                break;

            case 2:

                child0.SetActive(false);
                child1.SetActive(false);
                child2.SetActive(true);
                child3.SetActive(false);

                nbSetActive++;

                if (nbSetActive >= 6)
                {

                    i++;
                    nbSetActive = 0;
                }
                break;

            case 3:
                child0.SetActive(false);
                child1.SetActive(false);
                child2.SetActive(false);
                child3.SetActive(true);
                
                break;
        }
    }

    public void changeDistance() {

        if (d > 3) {

            d = 0;
        } else {

            d += 1;
        }

        switch (d) {

            case 0:
                this.transform.position = new Vector3(20, this.transform.position.y, this.transform.position.z);
                break;

            case 1:
                this.transform.position = new Vector3(this.transform.position.x + 10, this.transform.position.y, this.transform.position.z);
                if (GetComponent<SC_DestroyMob>().scoredetection == true)
                {

                    score += 100;
                }
                break;

            case 2:
                this.transform.position = new Vector3(this.transform.position.x + 10, this.transform.position.y, this.transform.position.z);
                if (GetComponent<SC_DestroyMob>().scoredetection == true)
                {

                    score += 200;
                }
                break;

            case 3:
                this.transform.position = new Vector3(this.transform.position.x + 10, this.transform.position.y, this.transform.position.z);
                if (GetComponent<SC_DestroyMob>().scoredetection == true)
                {

                    score += 300;
                }
                break;
        }
    }

    public void ResetAll() {

        i = 0;
        d = 0;
        score = 0;
        nbSetActive = 0;

        //=====================================================================================//

        child1.transform.GetChild(0).gameObject.SetActive(true);
        child1.transform.GetChild(1).gameObject.SetActive(true);

        //=====================================================================================//

        child2.transform.GetChild(0).gameObject.SetActive(true);
        child2.transform.GetChild(1).gameObject.SetActive(true);
        child2.transform.GetChild(2).gameObject.SetActive(true);

        //=====================================================================================//

        changePhase();
    }
}