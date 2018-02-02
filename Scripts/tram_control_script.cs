using System.Collections;
using UnityEngine;
public class tram_control_script : MonoBehaviour
{

    // put the points from unity interface
    public Transform[] points;

    public int currentLocation = 0;
    Transform target_Point = null;
    public float reach_Dist = 1f;
    public float speed_ = 4f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    IEnumerator WaitForPassengers()
    {
        yield return new WaitForSeconds(500);
        Debug.Log("Just waited 1 second");
        
    }

    void Update()
    {
        // check if we have somewere to walk
        if (currentLocation < this.points.Length)
        {
            if (points == null)
                target_Point = points[currentLocation];
            jedz();
        }

        
        if (currentLocation == 3)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = -14.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
        if (currentLocation == 7)
        {
            StartCoroutine(WaitForPassengers());
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = -12.0f;
            transform.rotation = Quaternion.Euler(temp);
        }

        /*
        if (currentWayPoint == 4)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 100.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
        if (currentWayPoint == 5)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 90.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
        if (currentWayPoint == 6)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 50.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
        if (currentWayPoint == 7)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 20.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
        if (currentWayPoint == 8)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = -10.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
        */



    }

    void jedz()
    {
        /* Vector3 dir = wayPointList[currentWayPoint].position - transform.position;
         // rotate towards the target
        
         transform.position += dir * Time.deltaTime * speed;
         // move towards the target
         //transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);
         //transform.forward = Vector3.RotateTowards(transform.forward, targetWayPoint.position - transform.position, speed * Time.deltaTime, 0.02f);
         //if (transform.position == targetWayPoint.position)
         //{
         //    currentWayPoint++;
         //    targetWayPoint = wayPointList[currentWayPoint];
         //}
         if (dir.magnitude <= reachDist)
         {
             currentWayPoint++;
         }
         if (currentWayPoint >= wayPointList.Length)
         {
             currentWayPoint = 0;
         }
        */
        float distans = Vector3.Distance(points[currentLocation].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, points[currentLocation].position, Time.deltaTime * speed_);

        if (distans <= reach_Dist)
        {
            currentLocation++;
        }

        if (currentLocation >= points.Length)
        {
            currentLocation = 0;
        }
    }


    void OnDraw_Gizmos()
    {
        if (points.Length > 0)
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] != null)
                {
                    Gizmos.DrawSphere(points[i].position, reach_Dist);
                }
            }
    }
}
