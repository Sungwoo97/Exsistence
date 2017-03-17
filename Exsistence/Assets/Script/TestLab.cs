using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLab : MonoBehaviour {

	// Use this for initialization
    //----------------안녕하세요 TestLab에 오신걸 환영합니다!!!!---------------------------------//
    //**********************이곳에서 별의 별 실험을 하십시오!!!**********************************//
	void Start () {
        Point myPoint = new Point(10, 15);
        int x;
        int y;

        myPoint.GetPoint(out x, out y);

        Debug.Log("myPoint"+ x+y);
      

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Point
{
    int x;
    int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void GetPoint(out int x, out int y)
    {
        x = this.x;
        y = this.y;
    }
    
}
