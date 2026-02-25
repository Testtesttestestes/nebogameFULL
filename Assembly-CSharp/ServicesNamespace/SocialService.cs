using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public class SocialService : AbstractService
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x170000AE")]
		public override short ServiceId
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x5A80", Offset = "0x5A80", VA = "0x5A80", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x5A81", Offset = "0x5A81", VA = "0x5A81")]
		public OpToken<IMessage, object> GetGiftsStatus()
		{
			return null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x5A82", Offset = "0x5A82", VA = "0x5A82")]
		public OpToken<IMessage, object> SendGift(uint giftId, ulong receiverId)
		{
			return null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x5A83", Offset = "0x5A83", VA = "0x5A83")]
		public OpToken<IMessage, object> RateGame(uint rate)
		{
			return null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x5A84", Offset = "0x5A84", VA = "0x5A84")]
		public SocialService()
		{
		}
	}
}
