using UnityEngine;

public class Minion : MonoBehaviour 
{
	void Update () 
	{
		transform.position = new Vector3(transform.position.x + Time.deltaTime, 
							transform.position.y, transform.position.z);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Border")
		{
			Destroy(gameObject);
		}
    }
}
