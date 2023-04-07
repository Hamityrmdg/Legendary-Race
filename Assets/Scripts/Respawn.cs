using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 checkPos;
    public GameObject player;

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.I))
        {
           
           player.transform.position = checkPos;
           player.transform.rotation = Quaternion.Euler(0,0,0);
        }
    }

}
