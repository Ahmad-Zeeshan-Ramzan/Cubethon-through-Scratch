using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour
{
    public Transform player;
    private float delayTime = 1.5f;
    private float animationdelayTime = 0f;
    public GameObject CompleteLevelUI;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacles"))
        {

            Invoke("Restart", delayTime);
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CompleteLevel"))
        {
            Invoke("CompleteLevel", animationdelayTime);
            Invoke("NextLevel", delayTime);
        }
    }
    void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    private void FixedUpdate()
    {
        if (player.position.y < -1)
        {
            Restart();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}