using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.WorldAxis.ClanEquipment.Events
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	public class ClanEquipmentEvents : AbstractMVCEvents
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x654E", Offset = "0x654E", VA = "0x654E")]
		public ClanEquipmentEvents()
		{
		}

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x14")]
		public Action DollArtifactsRequestedEvent;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x18")]
		public Action DataChangedEvent;
	}
}
