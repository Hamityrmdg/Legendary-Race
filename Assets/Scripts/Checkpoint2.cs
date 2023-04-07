using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            FindObjectOfType<Respawn2>().checkPos2 = other.transform.position;
        }
    }
}
