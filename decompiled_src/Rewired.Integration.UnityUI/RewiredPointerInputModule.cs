using System.Collections.Generic;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public abstract class RewiredPointerInputModule : BaseInputModule
{
	protected class MouseState
	{
		private List<ButtonState> m_TrackedButtons;

		public ButtonState GetButtonState(int button)
		{
			throw null;
		}

		public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
		{
			throw null;
		}

		public MouseState()
		{
			throw null;
		}
	}

	public class MouseButtonEventData
	{
		public PointerEventData.FramePressState buttonState;

		public PlayerPointerEventData buttonData;

		public bool PressedThisFrame()
		{
			throw null;
		}

		public bool ReleasedThisFrame()
		{
			throw null;
		}

		public MouseButtonEventData()
		{
			throw null;
		}
	}

	protected class ButtonState
	{
		private int m_Button;

		private MouseButtonEventData m_EventData;

		public MouseButtonEventData eventData
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public int button
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public ButtonState()
		{
			throw null;
		}
	}

	private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
	{
		private Vector2 m_MousePosition;

		private Vector2 m_MousePositionPrev;

		private int m_LastUpdatedFrame;

		int IMouseInputSource.playerId
		{
			get
			{
				throw null;
			}
		}

		bool IMouseInputSource.enabled
		{
			get
			{
				throw null;
			}
		}

		bool IMouseInputSource.locked
		{
			get
			{
				throw null;
			}
		}

		int IMouseInputSource.buttonCount
		{
			get
			{
				throw null;
			}
		}

		Vector2 IMouseInputSource.screenPosition
		{
			get
			{
				throw null;
			}
		}

		Vector2 IMouseInputSource.screenPositionDelta
		{
			get
			{
				throw null;
			}
		}

		Vector2 IMouseInputSource.wheelDelta
		{
			get
			{
				throw null;
			}
		}

		bool ITouchInputSource.touchSupported
		{
			get
			{
				throw null;
			}
		}

		int ITouchInputSource.touchCount
		{
			get
			{
				throw null;
			}
		}

		bool IMouseInputSource.GetButtonDown(int button)
		{
			throw null;
		}

		bool IMouseInputSource.GetButtonUp(int button)
		{
			throw null;
		}

		bool IMouseInputSource.GetButton(int button)
		{
			throw null;
		}

		Touch ITouchInputSource.GetTouch(int index)
		{
			throw null;
		}

		private void TryUpdate()
		{
			throw null;
		}

		public UnityInputSource()
		{
			throw null;
		}
	}

	public const int kMouseLeftId = -1;

	public const int kMouseRightId = -2;

	public const int kMouseMiddleId = -3;

	public const int kFakeTouchesId = -4;

	private const int customButtonsStartingId = -2147483520;

	private const int customButtonsMaxCount = 128;

	private const int customButtonsLastId = -2147483392;

	private readonly List<IMouseInputSource> m_MouseInputSourcesList;

	private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

	private ITouchInputSource m_UserDefaultTouchInputSource;

	private UnityInputSource __m_DefaultInputSource;

	private readonly MouseState m_MouseState;

	private UnityInputSource defaultInputSource
	{
		get
		{
			throw null;
		}
	}

	private IMouseInputSource defaultMouseInputSource
	{
		get
		{
			throw null;
		}
	}

	protected ITouchInputSource defaultTouchInputSource
	{
		get
		{
			throw null;
		}
	}

	protected virtual bool isMouseSupported
	{
		get
		{
			throw null;
		}
	}

	protected bool IsDefaultMouse(IMouseInputSource mouse)
	{
		throw null;
	}

	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
	{
		throw null;
	}

	public void RemoveMouseInputSource(IMouseInputSource source)
	{
		throw null;
	}

	public void AddMouseInputSource(IMouseInputSource source)
	{
		throw null;
	}

	public int GetMouseInputSourceCount(int playerId)
	{
		throw null;
	}

	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
	{
		throw null;
	}

	public void RemoveTouchInputSource(ITouchInputSource source)
	{
		throw null;
	}

	public void AddTouchInputSource(ITouchInputSource source)
	{
		throw null;
	}

	public int GetTouchInputSourceCount(int playerId)
	{
		throw null;
	}

	protected void ClearMouseInputSources()
	{
		throw null;
	}

	protected abstract bool IsDefaultPlayer(int playerId);

	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
	{
		throw null;
	}

	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
	{
		throw null;
	}

	protected void RemovePointerData(PlayerPointerEventData data)
	{
		throw null;
	}

	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
	{
		throw null;
	}

	protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
	{
		throw null;
	}

	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
	{
		throw null;
	}

	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		throw null;
	}

	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
	{
		throw null;
	}

	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
	{
		throw null;
	}

	public override bool IsPointerOverGameObject(int pointerTypeId)
	{
		throw null;
	}

	protected void ClearSelection()
	{
		throw null;
	}

	public override string ToString()
	{
		throw null;
	}

	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
		throw null;
	}

	protected void CopyFromTo(PointerEventData from, PointerEventData to)
	{
		throw null;
	}

	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
	{
		throw null;
	}

	protected RewiredPointerInputModule()
	{
		throw null;
	}
}
