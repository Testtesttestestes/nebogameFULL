using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;
using UI.Elements.GenericList;

namespace Gameplay.Fresco.View.Groups
{
	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x20007FD")]
	public class FrescoGroupListElementArgs : GenericListElementArgs
	{
		// Token: 0x06003003 RID: 12291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003003")]
		[Address(RVA = "0x8069", Offset = "0x8069", VA = "0x8069")]
		public FrescoGroupListElementArgs()
		{
		}

		// Token: 0x04001A45 RID: 6725
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0xC")]
		public bool IsOwn;

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x10")]
		public Action<ulong> OnFrescoClick;

		// Token: 0x04001A47 RID: 6727
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x14")]
		public Protocol.Dic.Fresco.Types.GroupsDic GroupsDic;

		// Token: 0x04001A48 RID: 6728
		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x18")]
		public SortedDictionary<Protocol.Fresco.Fresco, Protocol.Dic.Fresco.Types.FrescoDic> FrescoListDic;
	}
}
