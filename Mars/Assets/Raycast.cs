using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{


    public float raycastDistance = 1000f;
    public float overlapTextBoxSize;
    public LayerMask spawnedObjectLayer;

    public GameObject ItemSpawned;





    void Start()
    {
        raycast();

    }

    // Update is called once per frame
    void Update()
    {

    }



    void raycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
        {
            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);

            Vector3 overlapTestBoxScale = new Vector3(overlapTextBoxSize, overlapTextBoxSize, overlapTextBoxSize);
            Collider[] collidersInsideBox = new Collider[1];
            int numberOfCollidersFound = Physics.OverlapBoxNonAlloc(hit.point, overlapTestBoxScale, collidersInsideBox, spawnRotation, spawnedObjectLayer);

            if (numberOfCollidersFound == 0)
            {
                Pick(hit.point, spawnRotation);
            }
            else
            {

            }

        }
    }



    void Pick(Vector3 positionSpawned, Quaternion rotationToSpawn)
    {
        GameObject clone = Instantiate(ItemSpawned, positionSpawned, rotationToSpawn);
    }
}