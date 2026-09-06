using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos;

public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
{
	private class Row
	{
		public InputAction action;

		public AxisRange actionRange;

		public Button button;

		public Text text;

		public Row()
		{
			throw null;
		}
	}

	private struct TargetMapping
	{
		public ControllerMap controllerMap;

		public int actionElementMapId;
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int index;

		public int actionElementMapId;

		public SimpleCombinedKeyboardMouseRemapping _003C_003E4__this;

		public _003C_003Ec__DisplayClass17_0()
		{
			throw null;
		}

		internal void _003CRedrawUI_003Eb__0()
		{
			throw null;
		}
	}

	private sealed class _003CStartListeningDelayed_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleCombinedKeyboardMouseRemapping _003C_003E4__this;

		public int index;

		public ControllerMap keyboardMap;

		public int actionElementMapToReplaceId;

		public ControllerMap mouseMap;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CStartListeningDelayed_003Ed__22(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private const string category = "Default";

	private const string layout = "Default";

	private const string uiCategory = "UI";

	private InputMapper inputMapper_keyboard;

	private InputMapper inputMapper_mouse;

	public GameObject buttonPrefab;

	public GameObject textPrefab;

	public RectTransform fieldGroupTransform;

	public RectTransform actionGroupTransform;

	public Text controllerNameUIText;

	public Text statusUIText;

	private List<Row> rows;

	private TargetMapping _replaceTargetMapping;

	private Player player
	{
		get
		{
			throw null;
		}
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void RedrawUI()
	{
		throw null;
	}

	private void ClearUI()
	{
		throw null;
	}

	private void InitializeUI()
	{
		throw null;
	}

	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
		throw null;
	}

	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
		throw null;
	}

	private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
	{
		throw null;
	}

	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
		throw null;
	}

	private void OnStopped(InputMapper.StoppedEventData data)
	{
		throw null;
	}

	public SimpleCombinedKeyboardMouseRemapping()
	{
		throw null;
	}
}
