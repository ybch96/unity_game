using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;


public class Player : MonoBehaviour
{
    public float rate = 0.0f;
    public float ratefire = 0.30f;
    public GameObject laserPrefab;
    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        Moving();
        LaserMark();

    }

    private void Moving()
    {
        float valorHorizontal = Input.GetAxis("Horizontal");
        float valorVertical = Input.GetAxis("Vertical");
        Debug.Log(valorHorizontal);
        transform.Translate(5  * Time.deltaTime *  valorHorizontal * Vector3.right);
        transform.Translate( 5 * Time.deltaTime * valorVertical *  Vector3.up);

        if (transform.position.x > 7)
        {
            transform.position = new Vector3(7, transform.position.y, 0);
        }
        else if (transform.position.x < -7)
        {
            transform.position = new Vector3(-7, transform.position.y, 0);
        }
        else if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -3)
        {
            transform.position = new Vector3(transform.position.x, -3, 0);
        }
    }

    private void LaserMark()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) 
        {
            if(Time.time > rate)
            {
                Instantiate(laserPrefab, transform.position + new Vector3(0, 3, 0), Quaternion.identity);
                rate = Time.time + ratefire;
            }
        }
    }
}

































































//public class Player : MonoBehaviour
//{
//    public GameObject laserPrefab;
//    public float speed = 2.0f;
//    private void Start()
//    {
//        transform.position = new Vector3(0, 0, 0);

//        Debug.Log("hola" + " " + transform.position);
//    }

//    private void Update()
//    {
//        movement();
//        moventLaser();
        

//    }

//   private void movement()
//    {
//        float translaVertical = Input.GetAxis("Vertical");
//        float translaHorizontal = Input.GetAxis("Horizontal");

//        Debug.Log(Time.deltaTime);

//        transform.Translate(Vector3.up * speed * translaVertical * Time.deltaTime);
//        transform.Translate(Vector3.right * speed * translaHorizontal * Time.deltaTime);

//        if (transform.position.y > 0)
//        {
//            transform.position = new Vector3(transform.position.x, 0, 0);
//        }
//        else if (transform.position.y < -3)
//        {
//            transform.position = new Vector3(transform.position.x, -3, 0);
//        }
//        else if (transform.position.x > 6)
//        {
//            transform.position = new Vector3(6, transform.position.y, 0);

//        }
//        else if (transform.position.x < -7)
//        {
//            transform.position = new Vector3(-7, transform.position.y, 0);
//        }
//    }

//    private void moventLaser(){
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            Instantiate(laserPrefab, transform.position + new Vector3(0, 3.2f ,0 ), Quaternion.identity);
//        }
//    }
//}
