using System;
using System.Collections.Generic;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;

namespace Core.Sorting
{
	// Token: 0x02000E74 RID: 3700
	[Token(Token = "0x2000E74")]
	public class QuestComparer : IComparer<IQuest>
	{
		// Token: 0x06005A27 RID: 23079 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0xA731", Offset = "0xA731", VA = "0xA731", Slot = "4")]
		public int Compare(IQuest x, IQuest y)
		{
			return 0;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0xA732", Offset = "0xA732", VA = "0xA732")]
		private int GetImportance(IQuest quest)
		{
			return 0;
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0xA733", Offset = "0xA733", VA = "0xA733")]
		public QuestComparer()
		{
		}
	}
}
