using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge"); //게임오브젝트 hpGauge찾기
       
    }
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f; //hpGauge 이미지 fillAmount값 -0.1 감소
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
