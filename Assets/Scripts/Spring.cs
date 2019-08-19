using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour
{
    public float springForce;
    private Animator shrinkAnim;
    // public AudioManager audioManager;
    public AudioSource[] soundEffects;

    private void Awake()
    {
        shrinkAnim = GetComponent<Animator>();
        // audioManager = FindObjectOfType<AudioManager>();
        soundEffects = GetComponents<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player") && player.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            int index = Random.Range(0, soundEffects.Length);
            soundEffects[index].Play();
            // audioManager.Play(audioManager.GetRandomSound());
            StartCoroutine("ShrinkEffect", player);
        }
    }

    private IEnumerator ShrinkEffect(Collider2D player)
    {
        shrinkAnim.SetBool("hasTouched", true);
        player.GetComponent<Rigidbody2D>().velocity = new Vector3(player.GetComponent<Rigidbody2D>().velocity.x, 0);
        player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, springForce));
        yield return new WaitForSeconds(0.1f);
        shrinkAnim.SetBool("hasTouched", false);
    }
}
