using UnityEngine;
//“dŽÔ(‹ž‹}1000Œ^“™)‚ð“®‚©‚·
public class KeikyuController : MonoBehaviour
{
    float speed = 0.01f;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Ä¶ŠJŽn
        audioSource.volume = 1.0f;
        audioSource.Play();
    }

    void Update()
    {
        transform.Translate(-this.speed, 0, 0);
        this.speed *= 1.01f;
        if(this.speed >1.5f)
        {
            this.speed = 1.5f;
        }

        if (transform.position.x < -800)
        {
            Destroy(gameObject);
        }


        audioSource.volume -= Time.deltaTime * 0.06f;
        audioSource.volume = Mathf.Clamp01(audioSource.volume);

    }
}