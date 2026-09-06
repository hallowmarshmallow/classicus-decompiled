using LevelImposter.Api;
using UnityEngine;

namespace LevelImposter.Builders;

public interface IElemBuilder
{
	void Build(LIElement elem, GameObject obj, LIShipStatus ship);
}
