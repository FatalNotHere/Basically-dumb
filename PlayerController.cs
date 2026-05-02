using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float sideSpeed = 10.0f;
    public float forwardSpeed = 5.0f;
    public TextMeshProUGUI uiText;
    private float scoreTimer = 0;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * sideSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        scoreTimer += Time.deltaTime;
        uiText.text = "Score: " + (int)scoreTimer;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0f;  
        }
    }
}