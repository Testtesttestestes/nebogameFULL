using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001006 RID: 4102
	[Token(Token = "0x2001006")]
	public class GoalsScope : AbstractEventBusScope
	{
		// Token: 0x06006144 RID: 24900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006144")]
		[Address(RVA = "0xAD6F", Offset = "0xAD6F", VA = "0xAD6F", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006145")]
		[Address(RVA = "0xAD70", Offset = "0xAD70", VA = "0xAD70")]
		public GoalsScope()
		{
		}

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0x8")]
		public Action<GoalsScope.GoalEventArgs> RewardTakenEvent;

		// Token: 0x02001007 RID: 4103
		[Token(Token = "0x2001007")]
		public class GoalEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001341 RID: 4929
			// (get) Token: 0x06006146 RID: 24902 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001341")]
			public IQuest Quest
			{
				[Token(Token = "0x6006146")]
				[Address(RVA = "0xAD71", Offset = "0xAD71", VA = "0xAD71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006147 RID: 24903 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006147")]
			[Address(RVA = "0xAD72", Offset = "0xAD72", VA = "0xAD72")]
			public GoalEventArgs(IApp app, IGame game, IQuest goalData)
			{
			}
		}
	}
}
