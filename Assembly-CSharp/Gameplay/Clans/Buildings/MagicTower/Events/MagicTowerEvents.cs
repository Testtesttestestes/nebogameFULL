using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.MagicTower.Events
{
	// Token: 0x02000AB8 RID: 2744
	[Token(Token = "0x2000AB8")]
	public class MagicTowerEvents : AbstractMVCEvents
	{
		// Token: 0x06004236 RID: 16950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004236")]
		[Address(RVA = "0x90EA", Offset = "0x90EA", VA = "0x90EA")]
		public MagicTowerEvents()
		{
		}

		// Token: 0x0400248D RID: 9357
		[Token(Token = "0x400248D")]
		[FieldOffset(Offset = "0x14")]
		public Action TowerInfoRequestedEvent;

		// Token: 0x0400248E RID: 9358
		[Token(Token = "0x400248E")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> SpellStateChanged;

		// Token: 0x0400248F RID: 9359
		[Token(Token = "0x400248F")]
		[FieldOffset(Offset = "0x1C")]
		public Action<uint> SpellUpdated;
	}
}
