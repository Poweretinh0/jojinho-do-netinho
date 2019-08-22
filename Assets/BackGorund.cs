using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGorund : MonoBehaviour
{
    [SerializeField] GameObject cenario;
    [SerializeField] Vector2 posiSpawn;
    void Start()
    {
        
    }
    void Update()
    {
        MoverCenario();
        if(transform.position.x < -18.5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void MoverCenario()
    {
        transform.Translate(Vector2.left * 4 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(cenario, posiSpawn, Quaternion.identity);
        }
    }
}
