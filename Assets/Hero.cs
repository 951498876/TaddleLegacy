using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agt;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.point);
                agt.SetDestination(hit.point);
            }
        }
        anim.SetFloat("heroSpeed", agt.velocity.magnitude);
        //print("anim.velocity.magnitude=" + agt.velocity.magnitude);
    }
}
