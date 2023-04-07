using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<Respawn>().checkPos = other.transform.position;
        }
    }
}
