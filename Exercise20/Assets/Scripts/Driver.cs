using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    const float MoveUnitsPerSecond = 5f;
    
    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 newPosition = transform.position;

        if (horizontalMovement != 0)
        {
            //add horizontal movement
            
            newPosition.x += horizontalMovement * MoveUnitsPerSecond * Time.deltaTime;
        }

        if(verticalMovement != 0)
        {
            //add vertical movement
            newPosition.y += verticalMovement * MoveUnitsPerSecond * Time.deltaTime;
        }

        //move the object
        transform.position = newPosition;
    }
}
