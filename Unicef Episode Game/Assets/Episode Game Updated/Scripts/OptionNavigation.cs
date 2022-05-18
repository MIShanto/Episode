using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionNavigation : MonoBehaviour
{
    public GameObject[] nextPanel;

    public EpisodeNavigation episodeNavObj;
    // Start is called before the first frame update
    void Start()
    {
        CancelInvoke();
        Debug.Log("Invoke stopped from Option");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void GoToOption(int optionNo)
    {
        for (int i = 0; i < nextPanel.Length; i++)
        {
            nextPanel[i].SetActive(false);
        }
        Debug.Log(" 2 current Panel "+gameObject+" next Panel "+nextPanel[optionNo]);
        //gameObject.SetActive(false);
        //nextPanel[optionNo].SetActive(true);
        episodeNavObj.nextPanel = nextPanel[optionNo];
        episodeNavObj.GoNext();
        if( nextPanel[optionNo].GetComponent<PanelProperty>())
        nextPanel[optionNo].GetComponent<PanelProperty>().sendPanelProperty();
    }
}
