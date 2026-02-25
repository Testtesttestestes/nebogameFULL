using System;
using System.Collections.Generic;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Antiq
{
	// Token: 0x02000D7B RID: 3451
	[Token(Token = "0x2000D7B")]
	internal class AntiqEvents : AbstractMVCEvents
	{
		// Token: 0x0600548D RID: 21645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548D")]
		[Address(RVA = "0xA240", Offset = "0xA240", VA = "0xA240")]
		public AntiqEvents()
		{
		}

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x14")]
		public Action GroupsChangedEvent;

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x18")]
		public Action<IList<GroupData>> AchievedGroupsChangedEvent;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x1C")]
		public Action<GroupData> CurrentGroupChangedEvent;

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x20")]
		public Action<ArtifactData> CurrentArtifactChangedEvent;
	}
}
