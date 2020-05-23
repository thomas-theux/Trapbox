using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTraps : MonoBehaviour {

    public Transform TrapsParent;
    public Transform SafeZoneParent;

    public GameObject SafeZone;

    public int TrapsToSpawn = 3;

    private float startingPosX = 0;
    private float previousTrapWidth = 5;

    private Object[] trapsArr;


    private void Awake() {
        // Load all traps in the folder into an array
        trapsArr = Resources.LoadAll("Traps", typeof(GameObject));

        for (int i = 0; i < TrapsToSpawn; i++) {

            // Instantiate trap
            int rndTrap = Random.Range(0, trapsArr.Length);

            GameObject newTrap = Instantiate(trapsArr[rndTrap]) as GameObject;
            newTrap.transform.position = new Vector3(startingPosX + previousTrapWidth, 0, 0);
            newTrap.transform.parent = TrapsParent;

            startingPosX += previousTrapWidth;
            previousTrapWidth = newTrap.GetComponent<TrapProperties>().TrapWidth;

            if (i != TrapsToSpawn - 1) {
                // Instantiate safe zone
                GameObject newSafeZone = Instantiate(SafeZone);
                newSafeZone.transform.position = new Vector3(startingPosX + previousTrapWidth, 0, 0);
                newSafeZone.transform.parent = SafeZoneParent;

                startingPosX += previousTrapWidth;
                previousTrapWidth = newSafeZone.GetComponent<TrapProperties>().TrapWidth;
            }
        }
    }

}
