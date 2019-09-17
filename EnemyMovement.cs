using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody enemyRb;

    public float speed = 5f;

    public bool dirRight = true;


    void Start()
    {
        //apenas puxando o rigidbody, não está sendo usado no scrpit, por enquanto
        enemyRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        //bool começa true, então ele vai para sempre para direita, caso seja falso irá para a esquerda.
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        //se o inimigo triggar com a tag, irá sempre inveter o bool, true para false, false para true.

        if (other.gameObject.CompareTag("limits"))
        {
            dirRight = !dirRight;
        }
    }

}
