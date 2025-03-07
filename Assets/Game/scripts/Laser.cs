using UnityEngine;

public class Laser : MonoBehaviour
{
    void Start()
    {
        
    }
     void Update()
    {
        transform.Translate(Vector3.up * 10 * Time.deltaTime);

        if(transform.position.y > 4)
        {
            Destroy(gameObject);
        }
    }
}
