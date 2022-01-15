using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
[SerializeField] private Transform targetPosition;
[SerializeField] private float speed = 1;
[SerializeField] private bool start = false;




    void FixedUpdate()
    {
     if(false) MoveToPointNotPhysics();
    }

    public void MoveToPointNotPhysics()
    {
        float distance = Vector3.Distance(transform.position, targetPosition.position);
        float movement = speed * Time.deltaTime;
        float increment = movement / distance;
        
        transform.position = Vector3.Lerp(transform.position, targetPosition.position, increment);
    }
    
    public void MoveTowardsNotPhysics()
    {
        transform.Translate(targetPosition.position.normalized * speed);
    }


}
