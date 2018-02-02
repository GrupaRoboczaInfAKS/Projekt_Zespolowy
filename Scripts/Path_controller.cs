using UnityEngine;
public class Path_controller : MonoBehaviour
{

    // put the points from unity interface
    public Transform[] wayPointList;

    public int currentWayPoint = 0;
    Transform targetWayPoint = null;
    public float reachDist = 1f;
    public float speed = 4f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // check if we have somewere to walk
        if (currentWayPoint < this.wayPointList.Length)
        {
            if (targetWayPoint == null)
                targetWayPoint = wayPointList[currentWayPoint];
            changePosition();
        }

        
        if (currentWayPoint == 4)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = -14.3f;
            transform.rotation = Quaternion.Euler(temp);
        }
        
        if (currentWayPoint == 8)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = -189.0f;
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

    void changePosition()
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
        float dist = Vector3.Distance(wayPointList[currentWayPoint].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, wayPointList[currentWayPoint].position, Time.deltaTime * speed);

        if (dist <= reachDist)
        {
            currentWayPoint++;
        }

        if (currentWayPoint >= wayPointList.Length)
        {
            currentWayPoint = 0;
        }
    }


    void OnDrawGizmos()
    {
        if (wayPointList.Length > 0)
            for (int i = 0; i < wayPointList.Length; i++)
            {
                if (wayPointList[i] != null)
                {
                    Gizmos.DrawSphere(wayPointList[i].position, reachDist);
                }
            }
    }
}
