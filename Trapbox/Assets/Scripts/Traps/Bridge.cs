using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {

    public GameObject BridgeCollider;


    private void Awake() {
        int rndPosZ = Random.Range(0, 14);
        BridgeCollider.transform.position = new Vector3(0, 0, rndPosZ);
    }
}
