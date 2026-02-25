using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C5 RID: 4805
	[Token(Token = "0x20012C5")]
	public class BlitzTournamentAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06007230 RID: 29232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001729")]
		protected override string Theme
		{
			[Token(Token = "0x6007230")]
			[Address(RVA = "0xBC39", Offset = "0xBC39", VA = "0xBC39", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007231")]
		[Address(RVA = "0xBC3A", Offset = "0xBC3A", VA = "0xBC3A", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007232")]
		[Address(RVA = "0xBC3B", Offset = "0xBC3B", VA = "0xBC3B", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007233")]
		[Address(RVA = "0xBC3C", Offset = "0xBC3C", VA = "0xBC3C")]
		private void FinalCombatCompleteEvent(BlitzTournamentScope.FinalCombatCompleteEventArgs e)
		{
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007234")]
		[Address(RVA = "0xBC3D", Offset = "0xBC3D", VA = "0xBC3D")]
		private void LeftQueueEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007235")]
		[Address(RVA = "0xBC3E", Offset = "0xBC3E", VA = "0xBC3E")]
		private void JoinedQueueEvent(BlitzTournamentScope.JoinedQueueEventArgs e)
		{
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007236")]
		[Address(RVA = "0xBC3F", Offset = "0xBC3F", VA = "0xBC3F")]
		public BlitzTournamentAnalyticsListener()
		{
		}

		// Token: 0x04003BD9 RID: 15321
		[Token(Token = "0x4003BD9")]
		private const string JOINED_QUEUE = "joined_queue";

		// Token: 0x04003BDA RID: 15322
		[Token(Token = "0x4003BDA")]
		private const string LEFT_QUEUE = "left_queue";

		// Token: 0x04003BDB RID: 15323
		[Token(Token = "0x4003BDB")]
		private const string FINAL_COMBAT_COMPLETE = "final_combat_complete";
	}
}
