using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001310 RID: 4880
	[Token(Token = "0x2001310")]
	public interface IWorldObjectEngine
	{
		// Token: 0x060073F2 RID: 29682
		[Token(Token = "0x60073F2")]
		void Init(WorldObjectEngineArgs args);

		// Token: 0x060073F3 RID: 29683
		[Token(Token = "0x60073F3")]
		void LateUpdate();

		// Token: 0x060073F4 RID: 29684
		[Token(Token = "0x60073F4")]
		void ResetPositions(Vector3 deltaPos);
	}
}
