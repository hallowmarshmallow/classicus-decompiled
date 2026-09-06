using System;
using TMPro;
using UnityEngine;

public class UseButtonManager : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<MapBehaviour> _003C_003E9__40_0;

		internal void _003CDoClick_003Eb__40_0(MapBehaviour m)
		{
		}
	}

	private static readonly Color DisabledColor;

	private static readonly Color EnabledColor;

	private static readonly Color VentDisabledColor;

	private static readonly Color VentEnabledColor;

	public SpriteRenderer UseButton;

	public Sprite UseImage;

	public Sprite SabotageImage;

	public Sprite VentImage;

	public Sprite AdminMapImage;

	public Sprite SecurityImage;

	public Sprite OptionsImage;

	public TextMeshPro UseText;

	public TextMeshPro SabotageText;

	public TextMeshPro VentText;

	public TextMeshPro AdminText;

	public TextMeshPro SecurityText;

	public TextMeshPro OptionsText;

	private TextMeshPro currentActiveText;

	private IUsable currentTarget;

	private static UseButtonManager _003CInstance_003Ek__BackingField;

	private bool classicTimerShown;

	private TextMeshPro ventAmountText;

	private bool ventAmountResolved;

	public static UseButtonManager Instance
	{
		get
		{
			return _003CInstance_003Ek__BackingField;
		}
		private set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	public IUsable CurrentTarget => null;

	private static bool ShowVentCyan(object target)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void UpdateVentAmountLeft()
	{
	}

	private static Transform FindChildRecursive(Transform root, string name)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void CreateTextsIfNeeded()
	{
	}

	private void CreateIfMissing(ref TextMeshPro field, string name)
	{
	}

	private void ShowText(TextMeshPro text, string content, float fontSize, float yPos)
	{
	}

	private void HideAllTexts()
	{
	}

	public void SetTarget(IUsable target)
	{
	}

	public void DoClick()
	{
	}

	internal void Refresh()
	{
	}
}
