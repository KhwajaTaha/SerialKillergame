using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemymovement : MonoBehaviour
{
    public Transform target;
    public int damage = 2;
    public GameObject Bulletprefab;
    private GameObject bullet;
    float speed = 5f;
    public float obstacleRange = 3.0f;
    Rigidbody rb;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        
            Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
            transform.LookAt(target);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if(Physics.SphereCast(ray,3.75f,out hit))
            {
                GameObject hitobject = hit.transform.gameObject;
                PlayerInfo playerinfo = hit.transform.GetComponent<PlayerInfo>();
                if (hitobject.GetComponent<PlayerInfo>())
                {
                    if(bullet == null )
                    {
                        playerinfo.hurt(damage);
                        bullet = Instantiate(Bulletprefab) as GameObject;
                        bullet.transform.position = transform.TransformPoint(Vector3.forward * 3.5f);
                        bullet.transform.rotation = transform.rotation;
                    }
                }
               
            }

        
    }
    void OnDrawGizmosSelected()
    {
       // Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(transform.position, lookradius);
    }
}
