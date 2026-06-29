using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    
    float pspeed = 0.10f;//移動スピードの入る箱

    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        

        Vector2 pos = transform.position;


        if (Keyboard.current.leftArrowKey.isPressed)
        {
            pos.x -= pspeed;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            pos.x += pspeed;
        }

        // 画面内に移動を制限
        pos.x = Mathf.Clamp(pos.x, -8.5f, 8.5f);
        pos.y = Mathf.Clamp(pos.y, -4.0f, 4.0f);

        transform.position = pos;

        

      

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (!other.CompareTag("BuckTrck0") && !other.CompareTag("NextRoom")) return;

        //間違いの方向に行ったら0番に戻される
        if (other.CompareTag("BuckTrck0"))
        {
            GameManager.Instance.GoBackToStart();
        }
        //正解の方向に行ったら次の部屋がランダムで選ばれる
        //また、8回連続で正解を選んだらクリアシーンに行く
        else if (other.CompareTag("NextRoom"))
        {
            GameManager.Instance.GoNextRoom();

        }
        
    }
}
