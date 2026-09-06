using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMinigame : Minigame
{
	public enum States : byte
	{
		PrepareSample = 0,
		Complete = 0x10,
		AwaitingStart = 0x20,
		Selection = 0x40,
		Processing = 0x80
	}

	private sealed class _003CBringPanelDown_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		private WaitForFixedUpdate _003Cwait_003E5__2;

		private Vector3 _003Cpos_003E5__3;

		private float _003Ci_003E5__4;

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

		public _003CBringPanelDown_003Ed__31(int _003C_003E1__state)
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

	private sealed class _003CBringPanelUp_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		public bool isBeginning;

		private WaitForFixedUpdate _003Cwait_003E5__2;

		private Vector3 _003Cpos_003E5__3;

		private float _003Ci_003E5__4;

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

		public _003CBringPanelUp_003Ed__30(int _003C_003E1__state)
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

	private sealed class _003CCoSelectTube_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int selectedTube;

		public int correctTube;

		public SampleMinigame _003C_003E4__this;

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

		public _003CCoSelectTube_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003CCoStartProcessing_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

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

		public _003CCoStartProcessing_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CDropLiquid_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		private WaitForSeconds _003CdropWait_003E5__2;

		private WaitForFixedUpdate _003Cwait_003E5__3;

		private Vector3 _003Cpos_003E5__4;

		private int _003Cstep_003E5__5;

		private float _003Cstart_003E5__6;

		private float _003CxTarg_003E5__7;

		private float _003Ci_003E5__8;

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

		public _003CDropLiquid_003Ed__37(int _003C_003E1__state)
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

	private sealed class _003CDropTube_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		public int id;

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

		public _003CDropTube_003Ed__32(int _003C_003E1__state)
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

	private static string[] ProcessingStrings;

	private const float PanelMoveDuration = 0.75f;

	private const byte TubeMask = 15;

	public TextRenderer UpperText;

	public TextRenderer LowerText;

	public float TimePerStep;

	public FloatRange platformY;

	public FloatRange dropperX;

	public SpriteRenderer CenterPanel;

	public SpriteRenderer Dropper;

	public SpriteRenderer[] Tubes;

	public SpriteRenderer[] Buttons;

	public SpriteRenderer LowerButton;

	public AudioClip ButtonSound;

	public AudioClip PanelMoveSound;

	public AudioClip FailSound;

	public AudioClip[] DropSounds;

	private RandomFill<AudioClip> dropSounds;

	private States State
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

	private int AnomalyId
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

	public void Awake()
	{
		throw null;
	}

	public override void Begin(PlayerTask task)
	{
		throw null;
	}

	private void SetPlatformBottom()
	{
		throw null;
	}

	private void SetPlatformTop()
	{
		throw null;
	}

	public void FixedUpdate()
	{
		throw null;
	}

	public IEnumerator BringPanelUp(bool isBeginning)
	{
		throw null;
	}

	public IEnumerator BringPanelDown()
	{
		throw null;
	}

	private IEnumerator DropTube(int id)
	{
		throw null;
	}

	public void SelectTube(int tubeId)
	{
		throw null;
	}

	private IEnumerator CoSelectTube(int correctTube, int selectedTube)
	{
		throw null;
	}

	public void NextStep()
	{
		throw null;
	}

	private IEnumerator CoStartProcessing()
	{
		throw null;
	}

	private IEnumerator DropLiquid()
	{
		throw null;
	}

	public SampleMinigame()
	{
		throw null;
	}

	static SampleMinigame()
	{
		throw null;
	}
}
