using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automovebox : PhysicsObject
{
    bool goingRight = false;
    public float enemyWalkTime = 4000f;
    float framesWalked = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (framesWalked < enemyWalkTime) //goingRight==false; 
        {
           
            framesWalked++;
            //Debug.Log(framesWalked); 

            /*if (framesWalked == enemyWalkTime)
            {
                goingRight = !goingRight;
                framesWalked = 0;
            }*/
            
        }
        else 
        {
            framesWalked = 0;
            goingRight = !goingRight; 
        }

        if (goingRight == true)
        {
            targetVelocity = Vector2.right;
        }

        else
        {
            targetVelocity = Vector2.left;
        }

        /*if (goingRight == true)
        {

            targetVelocity = Vector2.right;
            framesWalked++;

            if (framesWalked == enemyWalkTime)
            {
                goingRight = !goingRight;
                framesWalked = 0;
            }

        }*/
    }
    


}
