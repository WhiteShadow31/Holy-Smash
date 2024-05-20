using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SC_Spawner : MonoBehaviour {

    //public List<GameObject> controllerPrefabs;
    //private InputDevice _targetDeviceL;

    public GameObject mob;

    public GameObject plateform;
    //public float speedPlateform = 0.5f;

    public GameObject batte;

    //public AudioSource claquementDoigt;

    void Start() {

        //List<InputDevice> devices = new List<InputDevice>();
        //InputDeviceCharacteristics leftControlCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        //InputDevices.GetDevicesWithCharacteristics(leftControlCharacteristics, devices);

        //if (devices.Count > 0)
        //{
        //    _targetDeviceL = devices[0];
        //    GameObject prefab = controllerPrefabs.Find(controller => controller.name == _targetDeviceL.name);
        //}
    }
    void Update() {

        //_targetDeviceL.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        //if(triggerValue == 1) {

        //    Debug.Log("claquement");
        //    claquementDoigt.Play();
        //    spawnMob();
        //}
    }

    public void spawnMob() {

        //plateform.transform.Translate(new Vector3(8.25f, -2.1f, 0) * speedPlateform * Time.deltaTime);
        //mob.transform.position = new Vector3(plateform.transform.position.x, plateform.transform.position.y, plateform.transform.position.z + 0.2f);
        //Invoke("mouvingPlateform", 1f);
        
        Instantiate(mob, new Vector3(plateform.transform.position.x, plateform.transform.position.y + 1.5f, plateform.transform.position.z), Quaternion.identity);
        
        //Instantiate(mob, new Vector3(9f, 2f, 0f), Quaternion.identity);
    }

    //public void mouvingPlateform() {

    //    plateform.transform.Translate(new Vector3(8.25f, -0.1f, 0) * speedPlateform * Time.deltaTime);
    //}

    public void spawnBatte() {

        //Destroy(batte);
        Instantiate(batte, new Vector3(6, 0.5f, -2), Quaternion.identity);
    }
}