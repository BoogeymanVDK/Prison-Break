using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    //Declaring variable of type aipath;
    public AIPath aiPath;

    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Speed "+ aiPath.desiredVelocity.x);
       
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-0.1f,0.1f,0.1f);
        }
        else if(aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(0.1f,0.1f,0.1f);
        }
    }
}
