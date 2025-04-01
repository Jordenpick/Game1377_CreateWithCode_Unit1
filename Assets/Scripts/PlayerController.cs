using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField]
    private float vechicleSpeed;

    [SerializeField]
    private float turnSpeed;

    [SerializeField]
    private float horizontalInput;

    [SerializeField] 
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(vechicleSpeed * Vector3.forward * Time.deltaTime * verticalInput);
        transform.Translate(turnSpeed * Vector3.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
