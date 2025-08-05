using UnityEngine;

public class Playercolll : MonoBehaviour
{
    public PlayerC playerC;
    public Score score;
    public Gamecontroller control;
    public AudioSource audioSource;
    public AudioSource audioSource2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
    }
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            if (other.gameObject.CompareTag("obstacle"))
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
                audioSource2.Play();
            playerC.enabled = false;
            control.Gameover();

        }
    }



}

