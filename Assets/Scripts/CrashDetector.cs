using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem crashParticle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");
        if (collision.gameObject.layer == layerIndex)
        {
            crashParticle.Play();
            Invoke("ReloadScene", delay);
        }
    }
    void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }
    
}
