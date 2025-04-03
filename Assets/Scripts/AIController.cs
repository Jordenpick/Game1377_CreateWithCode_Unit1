using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField]
    private float verticalSpeed;
    [SerializeField]
    private float lifeTime = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed);
    }
}

