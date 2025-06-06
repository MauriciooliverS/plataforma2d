using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform a, b;
    private bool direita;
    [Header("Velocidade Movimento")]
    public float speedMove = 7f;
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        followPoints();
    }
    private void followPoints()
    {
        if(direita){
            transform.localScale = new Vector3(1f, 1f, 1f);
            if(Vector2.Distance(transform.position, b.position) < 0.1f){
                direita = false; //inverte o lado
            }
            transform.position = Vector2.MoveTowards(transform.position, b.position, speedMove * Time.deltaTime);
        }else{
            transform.localScale = new Vector3(-1f, 1f, 1f);
            if(Vector2.Distance(transform.position, a.position) < 0.1f){
                direita = true; //direita
            }
            transform.position = Vector2.MoveTowards(transform.position, a.position, speedMove * Time.deltaTime);
        }
    }
    void Death()
    {
        Destroy(transform.parent.gameObject);
    }
}

