using UnityEngine;
//using System.Random;

public class CubeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rotateRight()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = -90;
        rotation.z = 0;
        transform.Rotate(rotation);
    }
    public void rotateLeft()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = 90;
        rotation.z = 0;
        transform.Rotate(rotation);
    }
    public void rotateUp()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = 0;
        rotation.z = -90;
        transform.Rotate(rotation);
    }
    public void rotateDown()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = 0;
        rotation.z = 90;
        transform.Rotate(rotation);
    }
    public void rotateRightY()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = 0;
        rotation.z = -90;
        transform.Rotate(rotation);
    }
    public void rotateLeftY()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = 0;
        rotation.z = 90;
        transform.Rotate(rotation);
    }
    public void rotateUpY()
    {
        Vector3 rotation;
        rotation.x = 90;
        rotation.y = 0;
        rotation.z = 0;
        transform.Rotate(rotation);
    }
    public void rotateDownY()
    {
        Vector3 rotation;
        rotation.x = -90;
        rotation.y = 0;
        rotation.z = 0;
        transform.Rotate(rotation);
    }

    public void rotateRightW()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = 0;
        rotation.z = -90;
        transform.Rotate(rotation);
    }
    public void rotateLeftW()
    {
        Vector3 rotation;
        rotation.x = 0;
        rotation.y = 0;
        rotation.z = 90;
        transform.Rotate(rotation);
    }
    public void rotateUpW()
    {
        Vector3 rotation;
        rotation.x = -90;
        rotation.y = 0;
        rotation.z = 0;
        transform.Rotate(rotation);
    }
    public void rotateDownW()
    {
        Vector3 rotation;
        rotation.x = 90;
        rotation.y = 0;
        rotation.z = 0;
        transform.Rotate(rotation);
    }

    public void rotateRandom()
    {
        int[] sides = new int[] { 90, -90, 0, 180 };
        //Random rnd = new Random();
        int index1 = Random.Range(0,4);
        int index2 = Random.Range(0, 4);
        int index3 = Random.Range(0, 4);

        Vector3 rotation;
        rotation.x = sides[index1];
        rotation.y = sides[index2];
        rotation.z = sides[index3];
        transform.Rotate(rotation);
    }
}
