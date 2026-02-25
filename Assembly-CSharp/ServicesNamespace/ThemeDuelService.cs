using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Themeduel;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	public class ThemeDuelService : AbstractService
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x170000B0")]
		public override short ServiceId
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x5A8D", Offset = "0x5A8D", VA = "0x5A8D", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A9")]
		public event Action<ProtoUserScoreChangedEvt> BalanceChangedEvent
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x5A8E", Offset = "0x5A8E", VA = "0x5A8E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x5A8F", Offset = "0x5A8F", VA = "0x5A8F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AA")]
		public event Action<ProtoUserEntryAttempsChangedEvt> EntryAttemptChangedEvent
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x5A90", Offset = "0x5A90", VA = "0x5A90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x5A91", Offset = "0x5A91", VA = "0x5A91")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AB")]
		public event Action<ProtoThemeDuelStateChangedEvt> StateChangedEvent
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x5A92", Offset = "0x5A92", VA = "0x5A92")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x5A93", Offset = "0x5A93", VA = "0x5A93")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x5A94", Offset = "0x5A94", VA = "0x5A94", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x5A95", Offset = "0x5A95", VA = "0x5A95")]
		public OpToken<IMessage, object> GetThemeDuelState()
		{
			return null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x5A96", Offset = "0x5A96", VA = "0x5A96")]
		public OpToken<IMessage, object> GetEventStoreItemsInfo()
		{
			return null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x5A97", Offset = "0x5A97", VA = "0x5A97")]
		public OpToken<IMessage, object> BuyEventShopItem(ulong price, ulong artId, int destSlot)
		{
			return null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x5A98", Offset = "0x5A98", VA = "0x5A98")]
		public ThemeDuelService()
		{
		}
	}
}
