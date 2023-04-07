using UnityEngine;

public class Respawn2 : MonoBehaviour
{
    public Vector3 checkPos2;
    public GameObject player2;

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.R))
        {

            player2.transform.position = checkPos2;
            player2.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
