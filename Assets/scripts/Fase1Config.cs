using UnityEngine;

public class Fase1Config : MonoBehaviour
{
    [SerializeField] private GameObject dialogoPlaca;
    [SerializeField] private GameObject aperteTeclaE;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogoPlaca.SetActive(false);
        aperteTeclaE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Placa"))
        {
            aperteTeclaE.SetActive(true);
            if(Input.GetKey(KeyCode.E))
            {
                dialogoPlaca.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Placa"))
        {
            dialogoPlaca.SetActive(false);
        }
}
}
