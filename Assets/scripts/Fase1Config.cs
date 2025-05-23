using UnityEngine;

public class Fase1Config : MonoBehaviour
{
    [SerializeField] private GameObject dialogoPlaca;
    [SerializeField] private GameObject aperteTeclaE;
    [SerializeField] private GameObject troll;
    [SerializeField] private GameObject mortetroll;
    [SerializeField] private GameObject chaoInvisivel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogoPlaca.SetActive(false);
        aperteTeclaE.SetActive(false);
        troll.SetActive(true);
        chaoInvisivel.SetActive(false);
        mortetroll.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Placa")
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
            aperteTeclaE.SetActive(false);
        }
        
}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Chaotroll"))
        {
            troll.SetActive(false);
            mortetroll.SetActive(true);
        }
        if(other.gameObject.CompareTag("Cherry"))
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Chaoinvisivel")
        {
            chaoInvisivel.SetActive(true);
        }
        
    }
}
