using System;
using System.Collections.Generic;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Notifier;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public class NotifierService : AbstractService
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x170000A6")]
		public override short ServiceId
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x59D6", Offset = "0x59D6", VA = "0x59D6", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x59D7", Offset = "0x59D7", VA = "0x59D7")]
		public OpToken<IMessage, object> GetGroups()
		{
			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x59D8", Offset = "0x59D8", VA = "0x59D8")]
		public OpToken<IMessage, object> UpdateGroups(IEnumerable<GroupSettings> groupSettings)
		{
			return null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x59D9", Offset = "0x59D9", VA = "0x59D9")]
		public NotifierService()
		{
		}
	}
}
