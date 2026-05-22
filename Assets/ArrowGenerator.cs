using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.3f; 
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; //delta값에 시간 더하기
        if (this.delta > this.span) //시간이 0,3초보다 크면
        {
            this.delta = 0; //시간 초기화
            GameObject go = Instantiate(arrowPrefab); //arrow의 prefab 생성
            int px = Random.Range(-9, 10);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
