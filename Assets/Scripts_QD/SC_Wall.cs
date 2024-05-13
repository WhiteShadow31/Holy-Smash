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

    public int i = 0;
    public int d = 0;

    public TMP_Text scoreText;
    public int score;

    void Start() {

        child0 = transform.GetChild(0).gameObject;
        child1 = transform.GetChild(1).gameObject;
        child2 = transform.GetChild(2).gameObject;
        child3 = transform.GetChild(3).gameObject;
    }

    void Update() {

        scoreText.text = "Score : " + score;
    }

    public void changeDifficulty() {



        if(i > 3) {

            i = 0;
        } else {

            i += 1;
        }

        switch (i) {

            case 0:
                child0.SetActive(true);
                child1.SetActive(false);
                child2.SetActive(false);
                child3.SetActive(false);
                if(GetComponent<SC_DestroyMob>().scoredetection == true) {

                    score += 100;
                }
                break;

            case 1:
                child0.SetActive(false);
                child1.SetActive(true);
                child2.SetActive(false);
                child3.SetActive(false);
                if (GetComponent<SC_DestroyMob>().scoredetection == true) {

                    score += 200;
                }
                break;

            case 2:
                child0.SetActive(false);
                child1.SetActive(false);
                child2.SetActive(true);
                child3.SetActive(false);
                if (GetComponent<SC_DestroyMob>().scoredetection == true) {

                    score += 300;
                }
                break;

            case 3:
                child0.SetActive(false);
                child1.SetActive(false);
                child2.SetActive(false);
                child3.SetActive(true);
                if (GetComponent<SC_DestroyMob>().scoredetection == true) {

                    score += 400;
                }
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
}