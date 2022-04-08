using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject DeathPanel;
    public GameObject MonyText;
   

    private void OnEnable()
    {
        GameManager.KillThaPlayer += ShowDeathPanel;

        
    }
    private void OnDisable()
    {
        GameManager.KillThaPlayer -= ShowDeathPanel;
    }
    private void Awake()
    {
      
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDeathPanel()
    {
        if (DeathPanel != null)
            DeathPanel.SetActive(true);
      
       

    }

    public void ShowErnedMony(int ernedmony)
    {
        MonyText.GetComponent<UnityEngine.UI.Text>().text = ernedmony.ToString();
    }


}
