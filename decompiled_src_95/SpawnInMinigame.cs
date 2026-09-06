using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnInMinigame : Minigame
{
	[Serializable]
	public struct SpawnLocation
	{
		public StringNames Name;

		public Sprite Image;

		public AnimationClip Rollover;

		public AudioClip RolloverSfx;

		public Vector3 Location;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SpawnLocation, float> _003C_003E9__8_0;

		public static Func<SpawnLocation, float> _003C_003E9__8_1;

		internal float _003CBegin_003Eb__8_0(SpawnLocation s)
		{
			return 0f;
		}

		internal float _003CBegin_003Eb__8_1(SpawnLocation s)
		{
			return 0f;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public SpawnLocation pt;

		public SpawnInMinigame _003C_003E4__this;

		internal void _003CBegin_003Eb__2()
		{
		}
	}

	private sealed class _003CCoSpawnAt_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl playerControl;

		public SpawnInMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSpawnAt_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CRunTimer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnInMinigame _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRunTimer_003Ed__10(int _003C_003E1__state)
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

	private sealed class _003CWaitForFinish_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnInMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForFinish_003Ed__13(int _003C_003E1__state)
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

	public SpawnLocation[] Locations;

	public PassiveButton[] LocationButtons;

	public TextMeshPro Text;

	public AudioClip DefaultRolloverSound;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private bool gotButton;

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	private IEnumerator RunTimer()
	{
		return null;
	}

	private void SpawnAt(SpawnLocation spawnPoint)
	{
	}

	private IEnumerator CoSpawnAt(PlayerControl playerControl, SpawnLocation spawnLocation)
	{
		return null;
	}

	public IEnumerator WaitForFinish()
	{
		return null;
	}
}
