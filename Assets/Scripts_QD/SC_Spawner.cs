using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SC_Spawner : MonoBehaviour {

    //public List<GameObject> controllerPrefabs;
    //private InputDevice _targetDeviceL;

    public GameObject mob;

    public int nbMob;

    //public GameObject plateform;
    //public float speedPlateform = 0.5f;

    public GameObject batte;

    //public AudioSource claquementDoigt;

    void Awake() {

        //List<InputDevice> devices = new List<InputDevice>();
        //InputDeviceCharacteristics leftControlCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        //InputDevices.GetDevicesWithCharacteristics(leftControlCharacteristics, devices);

        //if (devices.Count > 0)
        //{
        //    _targetDeviceL = devices[1];
        //    //GameObject prefab = controllerPrefabs.Find(controller => controller.name == _targetDeviceL.name);
        //}

        nbMob = 0;
    }
    void Update() {

        //_targetDeviceL.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);

        //if (triggerValue == 1)
        //{

        //    spawnMob();
        //    Debug.Log("claquement");
        //    claquementDoigt.Play();
        //}

        if (nbMob < 1)
        {

            nbMob++;
            spawnMob();
        }
    }

    public void spawnMob() {

        //plateform.transform.Translate(new Vector3(8.25f, -2.1f, 0) * speedPlateform * Time.deltaTime);
        //mob.transform.position = new Vector3(plateform.transform.position.x, plateform.transform.position.y, plateform.transform.position.z + 0.2f);
        //Invoke("mouvingPlateform", 1f);
        
        Instantiate(mob, new Vector3(8.25f, 1f, 0), Quaternion.identity);

        //Invoke("CanonMobUp", 1f);

        //Instantiate(mob, new Vector3(9f, 2f, 0f), Quaternion.identity);
    }

    //public void mouvingPlateform() {

    //    plateform.transform.Translate(new Vector3(8.25f, -0.1f, 0) * speedPlateform * Time.deltaTime);
    //}

    //public void CanonMobUp() {

    //    mob.GetComponent<Rigidbody>().AddForce(Vector3.up * 20f, ForceMode.Impulse);
    //}

    public void spawnBatte() {

        //Destroy(batte);
        Instantiate(batte, new Vector3(7.5f, 1f, -2.5f), Quaternion.identity);
    }

    //IEnumerator waitCoroutine()
    //{

    //    //yield on a new YieldInstruction that waits for x seconds.
    //    yield return new WaitForSeconds(5);
    //    Destroy(mob);
    //}
}