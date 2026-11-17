using TMPro;
using UnityEngine;

public class Botaodinheiro : MonoBehaviour
{
    public TextMeshProUGUI Contadordinheiro;
    public int dinheiro = 0;
    public void Start()
    {
        Ganhardinheiro();
    }
    public void Ganhardinheiro() 
    {
        dinheiro = dinheiro + 1;
        Debug.Log("Dinheiro: " + dinheiro);
        Contadordinheiro.text = "Dinheiro: " + dinheiro;
    }
}
