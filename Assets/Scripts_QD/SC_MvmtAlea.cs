using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MvmtAlea : MonoBehaviour {

    public float yMax;
    public float zMax;
    public float yMin;
    public float zMin;

    public float speedMax;

    private float y;
    private float z;
    private float time;
    private float angle;

    // Use this for initialization
    void Start()
    {
        y = Random.Range(-speedMax, speedMax);
        z = Random.Range(-speedMax, speedMax);
        //angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
        //transform.localRotation = Quaternion.Euler(0, angle, 0);
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (transform.localPosition.y > yMax)
        {
            y = Random.Range(-speedMax, 0.0f);
            //angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            //transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }
        if (transform.localPosition.y < yMin)
        {
            y = Random.Range(0.0f, speedMax);
            //angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            //transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }
        if (transform.localPosition.z > zMax)
        {
            z = Random.Range(-speedMax, 0.0f);
            //angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            //transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }
        if (transform.localPosition.z < zMin)
        {
            z = Random.Range(0.0f, speedMax);
            //angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            //transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }


        if (time > 1.0f)
        {
            y = Random.Range(-speedMax, speedMax);
            z = Random.Range(-speedMax, speedMax);
            //angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            //transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }

        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + y, transform.localPosition.z + z);
    }
}