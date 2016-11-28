using UnityEngine;
using System.Collections;


public class ballStop : MonoBehaviour {


    private int ballHitTimes = 0;
    private GameObject m_ball;


	// Use this for initialization
	void Start () {

       // m_ball.GetComponent<Collider2D>();


	
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other )
    {
        Debug.Log(other.collider.tag);

        if(other.collider.tag == "wall")
        {
            ballHitTimes++;

        }
        
        if(ballHitTimes >= 6)
        {
            //ballHitTimes = 0;
            this.GetComponent<Collider2D>().isTrigger = true;  //

            Destroy(GetComponent<ballStop>());  //破坏脚本


        }

    }
}
