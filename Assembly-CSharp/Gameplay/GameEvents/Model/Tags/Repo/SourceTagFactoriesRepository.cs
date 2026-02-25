using System;
using System.Collections.Generic;
using Gameplay.GameEvents.Model.Tags.Factories;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags.Repo
{
	// Token: 0x020007BF RID: 1983
	[Token(Token = "0x20007BF")]
	public class SourceTagFactoriesRepository : ISourceTagFactoriesRepository
	{
		// Token: 0x06002EC7 RID: 11975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x7F3F", Offset = "0x7F3F", VA = "0x7F3F")]
		public SourceTagFactoriesRepository()
		{
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0x7F40", Offset = "0x7F40", VA = "0x7F40", Slot = "4")]
		public ISourceTagFactory GetFactory(EventTypeDic.Types.SourceTypes id)
		{
			return null;
		}

		// Token: 0x0400199F RID: 6559
		[Token(Token = "0x400199F")]
		[FieldOffset(Offset = "0x8")]
		public readonly Dictionary<EventTypeDic.Types.SourceTypes, ISourceTagFactory> Factories;
	}
}
