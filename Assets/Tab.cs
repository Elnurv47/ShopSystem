using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class Tab : MonoBehaviour, IPointerClickHandler
{
    private TabGroup _tabGroup;
    private Image _image;
    [SerializeField] private GameObject _displayPanel;

    public GameObject DisplayPanel { get => _displayPanel; }

    private void Awake()
    {
        _tabGroup = GetComponentInParent<TabGroup>();
        _image = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _tabGroup.ResetTabs();
        _displayPanel.SetActive(true);
        _image.color = Color.blue;
    }
}
