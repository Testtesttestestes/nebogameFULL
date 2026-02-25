using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.SmallGames;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class SmallGamesService : AbstractService
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x170000AD")]
		public override short ServiceId
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x5A72", Offset = "0x5A72", VA = "0x5A72", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A5")]
		public event Action<ProtoAdditionalRewardChangedEvt> AdditionalRewardChangedEvent
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x5A73", Offset = "0x5A73", VA = "0x5A73")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x5A74", Offset = "0x5A74", VA = "0x5A74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A6 RID: 166
		// (add) Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A6")]
		public event Action<ProtoRewardChangedEvt> RewardChangedEvent
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x5A75", Offset = "0x5A75", VA = "0x5A75")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x5A76", Offset = "0x5A76", VA = "0x5A76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x5A77", Offset = "0x5A77", VA = "0x5A77", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x5A78", Offset = "0x5A78", VA = "0x5A78")]
		public OpToken<IMessage, object> GetJackpotInfo(SlotMachineType slotMachineType)
		{
			return null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x5A79", Offset = "0x5A79", VA = "0x5A79")]
		public OpToken<IMessage, object> GetLastJackpotInfo(SlotMachineType slotMachineType)
		{
			return null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x5A7A", Offset = "0x5A7A", VA = "0x5A7A")]
		public OpToken<IMessage, object> GetFreeAttempts(SlotMachineType slotMachineType)
		{
			return null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x5A7B", Offset = "0x5A7B", VA = "0x5A7B")]
		public OpToken<IMessage, object> LaunchWheelsDiamond(uint scrollCount)
		{
			return null;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x5A7C", Offset = "0x5A7C", VA = "0x5A7C")]
		public OpToken<IMessage, object> RegisterVisit()
		{
			return null;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x5A7D", Offset = "0x5A7D", VA = "0x5A7D")]
		public OpToken<IMessage, object> TakeDailyBonus()
		{
			return null;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x5A7E", Offset = "0x5A7E", VA = "0x5A7E")]
		public OpToken<IMessage, object> LaunchWheelsOnyx(uint scrollCount)
		{
			return null;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x5A7F", Offset = "0x5A7F", VA = "0x5A7F")]
		public SmallGamesService()
		{
		}
	}
}
