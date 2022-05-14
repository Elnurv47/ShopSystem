using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

[RequireComponent(typeof(Image))]
public class Tab : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private TabGroup _tabGroup;
    private Image _background;
    private bool _isSelected;

    [SerializeField] private Color _defaultColor;
    [SerializeField] private Color _tintColor;
    [SerializeField] private Color _selectedColor;

    [SerializeField] private GameObject _productUIContainer;

    private void Awake()
    {
        _tabGroup = GetComponentInParent<TabGroup>();
        _background = GetComponent<Image>();
    }
    internal void Select()
    {
        _isSelected = true;
        _background.color = _selectedColor;
        _productUIContainer.SetActive(true);
    }

    internal void Deselect()
    {
        _isSelected = false;
        _background.color = _defaultColor;
        _productUIContainer.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _tabGroup.ResetTabs();
        _productUIContainer.SetActive(true);
        _background.color = _selectedColor;
        _isSelected = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_isSelected) return;

        _background.color = _tintColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_isSelected) return;

        _background.color = _defaultColor;
    }
}
