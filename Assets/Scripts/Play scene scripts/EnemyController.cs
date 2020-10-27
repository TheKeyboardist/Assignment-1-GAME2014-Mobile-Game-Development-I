using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public bool canMove;
    private Transform target;
    private GameObject targetBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        PickATarget();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);
        if(Vector2.Distance(transform.position, target.position) < 0.001f)
        {
            Destroy(targetBody);
            PickATarget();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    void PickATarget()
    {
        GameObject[] allTargets = GameObject.FindGameObjectsWithTag("Livestock");
        targetBody = allTargets[Random.Range(0, allTargets.Length)];
        target = targetBody.transform;   
    }
}