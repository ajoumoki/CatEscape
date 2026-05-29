using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerconstoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LbuttonDown()
    {
        transform.Translate(-2, 0, 0); //x좌표 -2만큼 이동
    }
    public void RbuttonDown()
    {
        transform.Translate(2, 0, 0); //x좌표 2만큼 이동
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //왼쪽 화살표 키를 눌렀을 때
        {
            transform.Translate(-0.3f, 0, 0); //x좌표 -0.3 이동
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.3f, 0, 0);
        }
    }
}
