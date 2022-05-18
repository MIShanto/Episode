using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeNavigation : MonoBehaviour
{

    public GameObject currentPanel;

    public GameObject nextPanel;
    public float waitTime = 2f;

    private bool dontCurrentPanel;
    // Start is called before the first frame update
    void Start()
    {
        dontCurrentPanel = true;
        AutoNavigation();
    }

    void OnEnable()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPanel(GameObject _currentPanel, GameObject _nextPanel,bool _dontCurrentPanel,float _waitTime)
    {
        Debug.Log("setting panel property");
        currentPanel = _currentPanel;
        nextPanel = _nextPanel;
        dontCurrentPanel = _dontCurrentPanel;
        waitTime = _waitTime;
    }

    public void GoNext()
    {
        CancelInvoke();
        //Debug.LogError(" 2 current Panel "+currentPanel+" next Panel "+nextPanel);
        if(!dontCurrentPanel)
        currentPanel.SetActive(false);
        if (nextPanel != null)
        {
            nextPanel.SetActive(true);
            if (nextPanel.GetComponent<PanelProperty>())
                nextPanel.GetComponent<PanelProperty>().sendPanelProperty();
            if (currentPanel.tag != "OptionPanel")
                AutoNavigation();
        }
    }
    
    
    // automiatic navigation without tap
    public void AutoNavigation()
    {
        Invoke("GoNext", waitTime);
    }
}
