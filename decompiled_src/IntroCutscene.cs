using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntroCutscene : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PlayerControl, string> _003C_003E9__31_0;

		public static Predicate<PlayerControl> _003C_003E9__36_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal string _003CCoBegin_003Eb__31_0(PlayerControl s)
		{
			throw null;
		}

		internal bool _003CCreatePlayers_003Eb__36_0(PlayerControl p)
		{
			throw null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public RoleTeamTypes team;

		public _003C_003Ec__DisplayClass39_0()
		{
			throw null;
		}

		internal bool _003CGetNumTeam_003Eb__0(PlayerControl p)
		{
			throw null;
		}
	}

	private sealed class _003CBeginTeam_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutscene _003C_003E4__this;

		public Color teamColor;

		public RoleTeamTypes team;

		public List<PlayerControl> yourTeam;

		public float duration;

		private bool _003CisRunner_003E5__2;

		private Color _003CtitleColor_003E5__3;

		private Color _003Cfade_003E5__4;

		private Color _003CimpColor_003E5__5;

		private Vector3 _003CtitlePos_003E5__6;

		private float _003Ctimer_003E5__7;

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

		public _003CBeginTeam_003Ed__38(int _003C_003E1__state)
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

	private sealed class _003CCoBegin_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutscene _003C_003E4__this;

		public List<PlayerControl> yourTeam;

		private List<PlayerControl> _003Cseekers_003E5__2;

		private List<PoolablePlayer> _003CrevealSlots_003E5__3;

		private bool _003CholdOverride_003E5__4;

		private HnSGameManager _003ChnsWait_003E5__5;

		private float _003ClingerDeadline_003E5__6;

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

		public _003CCoBegin_003Ed__31(int _003C_003E1__state)
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

	private sealed class _003CRetryTaskTextWhenRoleArrives_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003Celapsed_003E5__2;

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

		public _003CRetryTaskTextWhenRoleArrives_003Ed__35(int _003C_003E1__state)
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

	public static IntroCutscene Instance;

	public TextMeshPro Title;

	public TextMeshPro ImpostorText;

	public TextMeshPro DescriptionText;

	public PoolablePlayer PlayerPrefab;

	public MeshRenderer BackgroundBar;

	public MeshRenderer Foreground;

	public FloatRange ForegroundRadius;

	public SpriteRenderer FrontMost;

	public AudioClip IntroStinger;

	public float BaseY;

	public Transform PlayerHolder;

	public TextMeshPro ImpostorName;

	public TextMeshPro ImpostorTitle;

	public Vector3 impostorPos;

	public float impostorScale;

	public Transform SeekerRevealAnchor;

	private AnimationClip HnSSeekerSpawnAnim;

	private AnimationClip HnSSeekerSpawnHorseAnim;

	private AnimationClip HnSSeekerSpawnHorseInGameAnim;

	private AnimationClip HnSSeekerSpawnLongAnim;

	private AnimationClip HnSSeekerSpawnLongInGameAnim;

	public PoolablePlayer HideAndSeekPlayerVisual;

	public PoolablePlayer HorseWrangleVisualSuit;

	public PoolablePlayer HorseWrangleVisualPlayer;

	public TextMeshPro SeekerCountdownText;

	public bool HnSIntroHoldOverride;

	public float HnSIntroHoldSeconds;

	private const float SeekerRevealToCountdownSeconds = 5f;

	public static bool IsPlaying
	{
		get
		{
			throw null;
		}
	}

	public IEnumerator CoBegin(List<PlayerControl> yourTeam)
	{
		throw null;
	}

	public void CheckSeekerHand_AnimEvent()
	{
		throw null;
	}

	private void ApplySeekerCosmetics(PoolablePlayer slot, PlayerControl player)
	{
		throw null;
	}

	private static Color GetTeamColor(RoleBehaviour role)
	{
		throw null;
	}

	private static IEnumerator RetryTaskTextWhenRoleArrives()
	{
		throw null;
	}

	private void CreatePlayers(List<PlayerControl> team, out List<PoolablePlayer> players)
	{
		throw null;
	}

	private static string RunnerIntroString(StringNames key, string fallback)
	{
		throw null;
	}

	private IEnumerator BeginTeam(List<PlayerControl> yourTeam, RoleTeamTypes team, Color teamColor, float duration = 3.2f)
	{
		throw null;
	}

	public int GetNumTeam(RoleTeamTypes team)
	{
		throw null;
	}

	public IntroCutscene()
	{
		throw null;
	}
}
