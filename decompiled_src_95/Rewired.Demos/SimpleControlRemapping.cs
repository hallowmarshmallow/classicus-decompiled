using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos;

public class SimpleControlRemapping : MonoBehaviour
{
	private class Row
	{
		public InputAction action;

		public AxisRange actionRange;

		public Button button;

		public Text text;
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public int index;

		public int actionElementMapId;

		public SimpleControlRemapping _003C_003E4__this;

		internal void _003CRedrawUI_003Eb__0()
		{
		}
	}

	private sealed class _003CStartListeningDelayed_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleControlRemapping _003C_003E4__this;

		public int index;

		public int actionElementMapToReplaceId;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartListeningDelayed_003Ed__28(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string category = "Default";

	private const string layout = "Default";

	private const string uiCategory = "UI";

	private InputMapper inputMapper;

	public GameObject buttonPrefab;

	public GameObject textPrefab;

	public RectTransform fieldGroupTransform;

	public RectTransform actionGroupTransform;

	public Text controllerNameUIText;

	public Text statusUIText;

	private ControllerType selectedControllerType;

	private int selectedControllerId;

	private List<Row> rows;

	private Player player => null;

	private ControllerMap controllerMap => null;

	private Controller controller => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void RedrawUI()
	{
	}

	private void ClearUI()
	{
	}

	private void InitializeUI()
	{
	}

	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	private void SetSelectedController(ControllerType controllerType)
	{
	}

	public void OnControllerSelected(int controllerType)
	{
	}

	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
	{
		return null;
	}

	private void OnControllerChanged(ControllerStatusChangedEventArgs args)
	{
	}

	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}
}
