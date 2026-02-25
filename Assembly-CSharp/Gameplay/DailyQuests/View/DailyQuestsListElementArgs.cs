using System;
using Core.Data;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000874 RID: 2164
	[Token(Token = "0x2000874")]
	public class DailyQuestsListElementArgs : GenericListElementArgs
	{
		// Token: 0x060032DD RID: 13021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DD")]
		[Address(RVA = "0x832F", Offset = "0x832F", VA = "0x832F")]
		public DailyQuestsListElementArgs()
		{
		}

		// Token: 0x04001BD3 RID: 7123
		[Token(Token = "0x4001BD3")]
		[FieldOffset(Offset = "0xC")]
		public IQuest Data;

		// Token: 0x04001BD4 RID: 7124
		[Token(Token = "0x4001BD4")]
		[FieldOffset(Offset = "0x10")]
		public UserData User;

		// Token: 0x04001BD5 RID: 7125
		[Token(Token = "0x4001BD5")]
		[FieldOffset(Offset = "0x14")]
		public Action<IQuest> ItemClickHandler;
	}
}
