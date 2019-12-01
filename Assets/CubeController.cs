using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //キューブの効果音（追加）
    private AudioSource block;

    // Use this for initialization
    void Start () {
        //AudioSourceコンポーネントを取得（追加）
        block = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update() {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
    
       
        
        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    //（追加）
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            Debug.Log("OnCollision");
            GetComponent<AudioSource>().Play();
        }
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "ground")
        {
            Debug.Log("OnCollision");
            GetComponent<AudioSource>().Play();
        }
    }
        
 }
