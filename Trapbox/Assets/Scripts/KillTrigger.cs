using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour {

    public KillPlayer KillPlayerScript;


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            KillPlayerScript.KillAndRespawn(other);
        }
    }

}
