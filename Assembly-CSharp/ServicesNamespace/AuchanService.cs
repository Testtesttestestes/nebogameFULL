using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class AuchanService : AbstractService
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x1700008F")]
		public override short ServiceId
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x580B", Offset = "0x580B", VA = "0x580B", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x580C", Offset = "0x580C", VA = "0x580C")]
		public OpToken<IMessage, object> GetAuchanItemsInfo()
		{
			return null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x580D", Offset = "0x580D", VA = "0x580D")]
		public OpToken<IMessage, object> BuyAuchanItem(ulong artifactId, uint? slotId, ResourceSet sellPrice)
		{
			return null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x580E", Offset = "0x580E", VA = "0x580E")]
		public AuchanService()
		{
		}
	}
}
