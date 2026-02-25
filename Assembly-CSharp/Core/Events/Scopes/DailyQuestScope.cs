using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FFD RID: 4093
	[Token(Token = "0x2000FFD")]
	public class DailyQuestScope : AbstractEventBusScope
	{
		// Token: 0x0600612E RID: 24878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612E")]
		[Address(RVA = "0xAD5A", Offset = "0xAD5A", VA = "0xAD5A", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600612F")]
		[Address(RVA = "0xAD5B", Offset = "0xAD5B", VA = "0xAD5B")]
		public DailyQuestScope()
		{
		}

		// Token: 0x04003410 RID: 13328
		[Token(Token = "0x4003410")]
		[FieldOffset(Offset = "0x8")]
		public Action<DailyQuestScope.DailyQuestEventArgs> RewardTakenEvent;

		// Token: 0x02000FFE RID: 4094
		[Token(Token = "0x2000FFE")]
		public class DailyQuestEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700133D RID: 4925
			// (get) Token: 0x06006130 RID: 24880 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700133D")]
			public IQuest Quest
			{
				[Token(Token = "0x6006130")]
				[Address(RVA = "0xAD5C", Offset = "0xAD5C", VA = "0xAD5C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006131 RID: 24881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006131")]
			[Address(RVA = "0xAD5D", Offset = "0xAD5D", VA = "0xAD5D")]
			public DailyQuestEventArgs(IApp app, IGame game, IQuest dailyQuestData)
			{
			}
		}
	}
}
