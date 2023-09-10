using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _playerRigidbody;

    private void Start()
    {
        _playerRigidbody= GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigidbody.useGravity= true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Floor")
        {
            Material mat=other.gameObject.GetComponent<MeshRenderer>().material;
            mat.color = Color.blue;
            Destroy(gameObject);
        }
    }
}
