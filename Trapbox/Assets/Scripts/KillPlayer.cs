using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public Transform DeathMarkerParent;
    public GameObject DeathMarker;


    public void KillAndRespawn(Collider other) {
        // Instantiate death marker
        GameObject newDeathMarker = Instantiate(DeathMarker);
        newDeathMarker.transform.position = new Vector3(
            other.transform.position.x,
            2.0f,
            other.transform.position.z
        );

        // Parent death marker
        newDeathMarker.transform.parent = DeathMarkerParent;

        // Respawn player
        other.transform.position = other.GetComponent<CharacterManager>().StartPos;
    }
    
}
