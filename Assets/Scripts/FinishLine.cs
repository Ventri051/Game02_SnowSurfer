using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem finishParticles;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");
        if (collision.gameObject.layer == layerIndex)
        {
            finishParticles.Play();
            Invoke("ReloadScene", delay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}