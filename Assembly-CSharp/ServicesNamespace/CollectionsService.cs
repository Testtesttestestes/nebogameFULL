using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class CollectionsService : AbstractService
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x1700009A")]
		public override short ServiceId
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x58F1", Offset = "0x58F1", VA = "0x58F1", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x58F2", Offset = "0x58F2", VA = "0x58F2")]
		public OpToken<IMessage, object> GetUserCollections(ulong userId)
		{
			return null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x58F3", Offset = "0x58F3", VA = "0x58F3")]
		public OpToken<IMessage, object> ImproveUserCollection(uint collectionId)
		{
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x58F4", Offset = "0x58F4", VA = "0x58F4")]
		public OpToken<IMessage, object> BuyUserCollection(uint collectionId)
		{
			return null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x58F5", Offset = "0x58F5", VA = "0x58F5")]
		public CollectionsService()
		{
		}
	}
}
