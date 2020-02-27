
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sphere; 
   public void Spawn(Vector3 position)
    {
        Instantiate(sphere).transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        //left mouse click 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

            //Make z position the z position of the prefab object
            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, sphere.transform.position.z);
            Spawn(adjustZ); 
        }
    }
}