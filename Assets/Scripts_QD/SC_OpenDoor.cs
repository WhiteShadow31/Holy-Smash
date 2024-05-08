using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpeningDoors()
    {

        if (this.tag == "Porte G")
        {

            this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.eulerAngles.x, -90, transform.eulerAngles.z), Time.time * 0.5f);
        }
        else
        {

            this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.eulerAngles.x, 90, transform.eulerAngles.z), Time.time * 0.5f);
        }
    }
}