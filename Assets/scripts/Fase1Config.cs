using UnityEngine;

public class Fase1Config : MonoBehaviour
{
    [SerializeField] private GameObject dialogoPlaca;
    [SerializeField] private GameObject dialogoPlaca2;
    [SerializeField] private GameObject dialogoPlaca3;
    [SerializeField] private GameObject aperteTeclaE;
    [SerializeField] private GameObject troll;
     [SerializeField] private GameObject troll2;
    [SerializeField] private GameObject morte;
    [SerializeField] private GameObject morte2;
    [SerializeField] private GameObject morte3;
    [SerializeField] private GameObject mortetroll;
    [SerializeField] private GameObject chaoInvisivel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Time.timeScale = 1;
        dialogoPlaca.SetActive(false);
        dialogoPlaca2.SetActive(false);
        dialogoPlaca3.SetActive(false);
        aperteTeclaE.SetActive(false);
        troll.SetActive(true);
        troll2.SetActive(true);
        chaoInvisivel.SetActive(false);
        mortetroll.SetActive(false);
        morte.SetActive(true);
        morte2.SetActive(true);
        morte3.SetActive(true);
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
            if(other.tag == "Placa2")
        {
            aperteTeclaE.SetActive(true);
            if(Input.GetKey(KeyCode.E))
            {
                dialogoPlaca2.SetActive(true);
            }
        }
        if(other.tag == "Placa3")
        {
            aperteTeclaE.SetActive(true);
            if(Input.GetKey(KeyCode.E))
            {
                dialogoPlaca3.SetActive(true);
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
        if(other.gameObject.CompareTag("Placa2"))
        {
            dialogoPlaca2.SetActive(false);
            aperteTeclaE.SetActive(false);
        }
        if(other.gameObject.CompareTag("Placa3"))
        {
            dialogoPlaca3.SetActive(false);
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
            morte.SetActive(false);
            morte2.SetActive(false);
            morte3.SetActive(false);
        }
        if (other.tag == "Morte")
        {
            Time.timeScale = 0;
        }
        if(other.tag == "Troll2")
        {
            troll2.SetActive(false);
        }
        if(other.tag == "Troll2Aparece")
        {
            troll2.SetActive(true);
        }

    }
}
