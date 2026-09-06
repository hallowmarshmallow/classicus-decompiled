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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal void _003CDoClick_003Eb__40_0(MapBehaviour m)
		{
			throw null;
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
			throw null;
		}
		private set
		{
			throw null;
		}
	}

	public IUsable CurrentTarget
	{
		get
		{
			throw null;
		}
	}

	private static bool ShowVentCyan(object target)
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void Update()
	{
		throw null;
	}

	private void UpdateVentAmountLeft()
	{
		throw null;
	}

	private static Transform FindChildRecursive(Transform root, string name)
	{
		throw null;
	}

	private void Awake()
	{
		throw null;
	}

	private void CreateTextsIfNeeded()
	{
		throw null;
	}

	private void CreateIfMissing(ref TextMeshPro field, string name)
	{
		throw null;
	}

	private void ShowText(TextMeshPro text, string content, float fontSize, float yPos)
	{
		throw null;
	}

	private void HideAllTexts()
	{
		throw null;
	}

	public void SetTarget(IUsable target)
	{
		throw null;
	}

	public void DoClick()
	{
		throw null;
	}

	internal void Refresh()
	{
		throw null;
	}

	public UseButtonManager()
	{
		throw null;
	}

	static UseButtonManager()
	{
		throw null;
	}
}
