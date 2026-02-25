using System;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000968 RID: 2408
	[Token(Token = "0x2000968")]
	public interface IStoneParticles
	{
		// Token: 0x06003943 RID: 14659
		[Token(Token = "0x6003943")]
		void SpawnParticles(StonesTypes stonesType, StoneMono.StoneSkinProvider provider);

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06003944 RID: 14660
		[Token(Token = "0x17000B3F")]
		Transform transform { [Token(Token = "0x6003944")] get; }

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06003945 RID: 14661
		[Token(Token = "0x17000B40")]
		GameObject gameObject { [Token(Token = "0x6003945")] get; }
	}
}
