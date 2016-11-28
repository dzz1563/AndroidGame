using UnityEngine;
using System.Collections;

public class config : MonoBehaviour {

    public static config Instance;

    public const string Wall = "wall";
    public const string onGruond = "down_wall";



	// Use this for initialization
	void Start () {

        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
