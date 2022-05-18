using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelProperty : MonoBehaviour
{

    public GameObject nextPanel;

    public EpisodeNavigation episodeNav;

    public float waitTimeForThis = 2f;
    public bool dontOffCurrentPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sendPanelProperty()
    {
        episodeNav.SetPanel(gameObject,nextPanel,dontOffCurrentPanel,waitTimeForThis);
        Debug.Log("1 current Panel "+gameObject+" next Panel "+nextPanel);
    }
}
