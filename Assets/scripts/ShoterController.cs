using UnityEngine;
using System.Collections;

public class ShoterController : MonoBehaviour {

	// Use this for initialization
    //public ShoterController Instance;  //设计控制类，看看

    public float ballSpeed;   //球的速度

    public bool readyShoot = true;
    
    private Transform s_ballPostion;  //球的初始位置
    private Transform paoshen_Postion; // 炮身体的位置
    private Transform pk_postion;      //炮口的位置

    private Transform rotation;


    Vector2 m_ShootPos;//发炮口的位置


    

	void Start () {


       // m_ball = CreatBall.Instance.readyBallNum[0];

       // Instance = this;


        

        paoshen_Postion = this.transform;

        s_ballPostion = paoshen_Postion.FindChild("shoter");  //炮身的位置

        pk_postion = s_ballPostion.FindChild("pk_point");     //炮口的位置



	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3  targPos = Input.mousePosition;
        Vector3  objPos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 direction = targPos - objPos;

        direction.z = 0f;
        direction = direction.normalized;

        if(direction.y >= 0.5f && Time.timeScale > 0  && targPos.y/Screen.height <= 0.85f)
        {

            transform.up = direction;

        
            if(  (Input.GetMouseButtonDown(0) || Input.GetKeyUp(KeyCode.Space) )  && readyShoot )
            {

                GameObject m_ball = CreatBall.Instance.readyBallNum[1];

                m_ShootPos = pk_postion.position;

                Vector2 shoterDir = pk_postion.position - paoshen_Postion.position;

                m_ball.transform.position = pk_postion.position;

                m_ball.GetComponent<Rigidbody2D>().isKinematic = false;

                m_ball.GetComponent<Rigidbody2D>().velocity = shoterDir * ballSpeed;

                m_ball.GetComponent<Collider2D>().isTrigger = false;

                m_ball.AddComponent<ballStop>();                            //球发射出去之后，添加上ballStop

                CreateBall();                                             //球发射出去之后，重新创建一个球



            }



        }




	}

    void CreateBall()
    {

        CreatBall.Instance.readyBallNum[1] = CreatBall.Instance.readyBallNum[0];

        CreatBall.Instance.readyBallNum[0].transform.position = m_ShootPos;

        //CreatBall.Instance.readyBallNum[1] = Instantiate(CreatBall.Instance.CreateBallNum[Random.Range(0, CreatBall.Instance.MaxBall)], CreatBall.Instance.readyBallNum[1].transform.position, Quaternion.identity) as GameObject;


    }




}
