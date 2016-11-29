using UnityEngine;
using System.Collections;

public class CreatBall : MonoBehaviour {

    public static CreatBall Instance;

	// Use this for initialization
    public GameObject [] CreateBallNum = new GameObject[8];
    public GameObject[] readyBallNum = new GameObject[2];

    private Vector3 readyPos;
    private Vector3 createPos;

    public int MaxBall = 8;



	void Start () {

        Instance = this;


        readyPos = GameObject.Find("readypos").transform.position;   //获取到炮口的位置
        createPos = GameObject.Find("createball").transform.position;

        readyBallNum[0] = Instantiate(CreateBallNum[Random.Range(0, MaxBall)], createPos, Quaternion.identity) as GameObject; //创建第一个球
       
        readyBallNum[1] = Instantiate(CreateBallNum[Random.Range(0, MaxBall)], readyPos, Quaternion.identity) as GameObject;  //创建第二个球




	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
