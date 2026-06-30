using UnityEngine;
//“dÔ(‹‹}1000Œ^“™)‚ğ“®‚©‚·
public class KeikyuController2 : MonoBehaviour
{
    float speed2;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Ä¶ŠJn
        audioSource.volume = 1.0f;
        audioSource.Play();
    }

    void Update()
    {
        
            speed2 = 1.5f;
        transform.Translate(-this.speed2, 0, 0);

        if (transform.position.x < -800)
        {
            Destroy(gameObject);
        }


        audioSource.volume -= Time.deltaTime * 0.1f;
        audioSource.volume = Mathf.Clamp01(audioSource.volume);

    }
}