using Hazel;
using UnityEngine;

public class DraggerRole : RoleBehaviour
{
	public enum RpcCalls
	{
		Drag,
		Release
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public byte bodyId;

		public _003C_003Ec__DisplayClass15_0()
		{
			throw null;
		}

		internal bool _003CDrag_003Eb__0(DeadBody b)
		{
			throw null;
		}
	}

	public AbilityButtonSettings settings;

	public VanillaButtonManager dragButton;

	public DeadBody nearestBody;

	public DeadBody draggedBody;

	public float dragSpeed;

	public override bool IsEnabled
	{
		get
		{
			throw null;
		}
	}

	public override string roleDisplayName
	{
		get
		{
			throw null;
		}
	}

	public override string roleDescription
	{
		get
		{
			throw null;
		}
	}

	public bool CanUse
	{
		get
		{
			throw null;
		}
	}

	public override void ConfigureRole()
	{
		throw null;
	}

	public void CheckDrag()
	{
		throw null;
	}

	public void CheckRelease()
	{
		throw null;
	}

	public void Drag(byte bodyId)
	{
		throw null;
	}

	public void Release()
	{
		throw null;
	}

	public override void OnFixedUpdate()
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	public void UpdateBodyVisibility()
	{
		throw null;
	}

	public void UpdateButton()
	{
		throw null;
	}

	public override void SetHudActive(bool active)
	{
		throw null;
	}

	public VanillaButtonManager CreateDragButton(Transform parent)
	{
		throw null;
	}

	public override void HandleRpc(MessageReader reader, int rpc)
	{
		throw null;
	}

	public override void OnAssign(PlayerControl player)
	{
		throw null;
	}

	public DraggerRole()
	{
		throw null;
	}
}
