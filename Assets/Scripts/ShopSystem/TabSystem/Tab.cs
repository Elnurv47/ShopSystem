using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class Tab : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private TabGroup _tabGroup;
    private Image _background;

    [SerializeField] private Color _defaultColor;
    [SerializeField] private Color _tintColor;
    [SerializeField] private Color _selectedColor;
    [SerializeField] private GameObject _displayPanel;

    public Color DefaultColor { get => _defaultColor; }

    public GameObject DisplayPanel { get => _displayPanel; }

    private void Awake()
    {
        _tabGroup = GetComponentInParent<TabGroup>();
        _background = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _tabGroup.ResetTabs();
        _displayPanel.SetActive(true);
        _background.color = _selectedColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _background.color = _tintColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _background.color = _defaultColor;
    }
}
