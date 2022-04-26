using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TabGroup : MonoBehaviour
{
    [SerializeField] private List<Tab> tabs;

    public void ResetTabs()
    {
        foreach (Tab tab in tabs)
        {
            tab.GetComponent<Image>().color = tab.DefaultColor;
            GameObject tabDisplayPanel = tab.DisplayPanel;
            tabDisplayPanel.SetActive(false);
        }
    }
}
