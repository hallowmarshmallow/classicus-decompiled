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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal float _003CBegin_003Eb__8_0(SpawnLocation s)
		{
			throw null;
		}

		internal float _003CBegin_003Eb__8_1(SpawnLocation s)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public SpawnLocation pt;

		public SpawnInMinigame _003C_003E4__this;

		public _003C_003Ec__DisplayClass8_0()
		{
			throw null;
		}

		internal void _003CBegin_003Eb__2()
		{
			throw null;
		}
	}

	private sealed class _003CCoSpawnAt_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl playerControl;

		public SpawnInMinigame _003C_003E4__this;

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

		public _003CCoSpawnAt_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CRunTimer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnInMinigame _003C_003E4__this;

		private float _003Ctime_003E5__2;

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

		public _003CRunTimer_003Ed__10(int _003C_003E1__state)
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

	private sealed class _003CWaitForFinish_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnInMinigame _003C_003E4__this;

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

		public _003CWaitForFinish_003Ed__13(int _003C_003E1__state)
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

	public SpawnLocation[] Locations;

	public PassiveButton[] LocationButtons;

	public TextMeshPro Text;

	public AudioClip DefaultRolloverSound;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private bool gotButton;

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	private IEnumerator RunTimer()
	{
		throw null;
	}

	private void SpawnAt(SpawnLocation spawnPoint)
	{
		throw null;
	}

	private IEnumerator CoSpawnAt(PlayerControl playerControl, SpawnLocation spawnLocation)
	{
		throw null;
	}

	public IEnumerator WaitForFinish()
	{
		throw null;
	}

	public SpawnInMinigame()
	{
		throw null;
	}
}
