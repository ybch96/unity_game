using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{

    public float speed = 2.0f;
    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        Debug.Log("hola" +" "+ transform.position);
    }

    private void Update()
    {
        float translaVertical = Input.GetAxis("Vertical");
        float translaHorizontal = Input.GetAxis("Horizontal");

        Debug.Log(Time.deltaTime);

        transform.Translate(Vector3.up * speed * translaVertical * Time.deltaTime );
        transform.Translate(Vector3.right * speed * translaHorizontal * Time.deltaTime );

        if(transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }else if(transform.position.y < -3)
        {
            transform.position = new Vector3(transform.position.x, -3, 0);
        }else if(transform.position.x > 6)
        {
            transform.position = new Vector3(6, transform.position.y, 0);

        }
        else if(transform.position.x < -7)
        {
            transform.position = new Vector3(-7, transform.position.y, 0);
        }

    }
}
