using UnityEngine;

public class Game_ProjectileManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float lifetime = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Lazy pizza destroyer code here
        lifetime += Time.deltaTime;
        if (3 < lifetime)
        {
            Destroy(gameObject);
            Debug.Log("Pizza Destroyed!");
        }

        transform.position += Vector3.fwd * Time.deltaTime * 20.0f;
        

    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log("Hit Something");
    }
}
