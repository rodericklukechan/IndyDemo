using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByTouch : MonoBehaviour
{
    // Start is called before the first frame update

    public GameController gameController; 


    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {

            if (other.tag == "Player")
            {
                gameController.GameOver();
            }
     }

/*
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        if (col.name == "EndPoint")
        {

            GameManager.instance.Win();
            //			Winning.SetActive (true);
            Debug.Log("Win");
        }
        else if (col.name == "CatRange")
        {
            col.transform.parent.GetComponent<CatController>().Alarm();

        }
        else if (col.name == "Line of Sight")
        {
            //	Debug.Log ("Parent Triggered");

        }
        else if (col.name == "Parent")
        {//it's a trigger of parent trigger area
        }
        if (col.tag == "Wood")
        {
            if (onGrass) return;
            playGrass();
            onGrass = true;
        }
        else if (col.tag == "Path")
        {
            if (!onGrass) return;
            playWood();
            onGrass = false;
        }
        else { }

    }

    */
}
