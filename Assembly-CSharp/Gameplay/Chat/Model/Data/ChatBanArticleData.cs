using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Chat.Model.Data
{
	// Token: 0x02000B0F RID: 2831
	[Token(Token = "0x2000B0F")]
	public class ChatBanArticleData
	{
		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D74")]
		public ChatBanDic BanDic
		{
			[Token(Token = "0x600444B")]
			[Address(RVA = "0x92FC", Offset = "0x92FC", VA = "0x92FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600444C")]
			[Address(RVA = "0x92FD", Offset = "0x92FD", VA = "0x92FD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444D")]
		[Address(RVA = "0x2290", Offset = "0x2290", VA = "0x2290")]
		public ChatBanArticleData()
		{
		}

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0xC")]
		public bool Selected;
	}
}
