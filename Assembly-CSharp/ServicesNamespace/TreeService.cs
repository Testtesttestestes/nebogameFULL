using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Tree;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	public class TreeService : AbstractService
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x170000B3")]
		public override short ServiceId
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x5AB4", Offset = "0x5AB4", VA = "0x5AB4", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B2")]
		public event Action<ProtoRegenTreeEvt> RegenTree
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x5AB5", Offset = "0x5AB5", VA = "0x5AB5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x5AB6", Offset = "0x5AB6", VA = "0x5AB6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x5AB7", Offset = "0x5AB7", VA = "0x5AB7", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x5AB8", Offset = "0x5AB8", VA = "0x5AB8")]
		public OpToken<IMessage, object> BuyLicense()
		{
			return null;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x5AB9", Offset = "0x5AB9", VA = "0x5AB9")]
		public OpToken<IMessage, object> GetBonus(ulong ownerId, uint bonusId)
		{
			return null;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x5ABA", Offset = "0x5ABA", VA = "0x5ABA")]
		public TreeService()
		{
		}
	}
}
