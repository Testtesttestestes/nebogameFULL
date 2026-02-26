using System;
using BestHTTP;
using Gameplay.FeedbackForm.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Auth2;
using Protocol.Consts;

namespace Gameplay.FeedbackForm.Service
{
	// Token: 0x0200081D RID: 2077
	[Token(Token = "0x200081D")]
	public class ServiceMessages
	{
		// Token: 0x060030E8 RID: 12520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E8")]
		[Address(RVA = "0x814A", Offset = "0x814A", VA = "0x814A")]
		public ServiceMessages()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_FeedbackForm_Service_ServiceMessages___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param5;
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}

		// Token: 0x0200081E RID: 2078
		[Token(Token = "0x200081E")]
		public class FeedbackFormMessage
		{
			// Token: 0x060030E9 RID: 12521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030E9")]
			[Address(RVA = "0x814B", Offset = "0x814B", VA = "0x814B")]
			public FeedbackFormMessage(ClientPlatform clientPlatform, string content, string language, string clientVersion)
			{
			}

			// Token: 0x060030EA RID: 12522 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030EA")]
			[Address(RVA = "0x814C", Offset = "0x814C", VA = "0x814C")]
			public FeedbackFormMessage(Themes theme, ClientPlatform clientPlatform, string content, string language, string clientVersion)
			{
			}

			// Token: 0x060030EB RID: 12523 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030EB")]
			[Address(RVA = "0x814D", Offset = "0x814D", VA = "0x814D")]
			public void Serialize(HTTPRequest request)
			{
			}

			// Token: 0x04001AB2 RID: 6834
			[Token(Token = "0x4001AB2")]
			[FieldOffset(Offset = "0x8")]
			public readonly Themes Theme;

			// Token: 0x04001AB3 RID: 6835
			[Token(Token = "0x4001AB3")]
			[FieldOffset(Offset = "0xC")]
			public readonly ClientPlatform ClientPlatform;

			// Token: 0x04001AB4 RID: 6836
			[Token(Token = "0x4001AB4")]
			[FieldOffset(Offset = "0x10")]
			public string Content;

			// Token: 0x04001AB5 RID: 6837
			[Token(Token = "0x4001AB5")]
			[FieldOffset(Offset = "0x14")]
			public readonly string Language;

			// Token: 0x04001AB6 RID: 6838
			[Token(Token = "0x4001AB6")]
			[FieldOffset(Offset = "0x18")]
			public readonly string ClientVersion;

			// Token: 0x04001AB7 RID: 6839
			[Token(Token = "0x4001AB7")]
			[FieldOffset(Offset = "0x1C")]
			public Provider Provider;

			// Token: 0x04001AB8 RID: 6840
			[Token(Token = "0x4001AB8")]
			[FieldOffset(Offset = "0x20")]
			[CanBeNull]
			public string Server;

			// Token: 0x04001AB9 RID: 6841
			[Token(Token = "0x4001AB9")]
			[FieldOffset(Offset = "0x24")]
			[CanBeNull]
			public string Uid;

			// Token: 0x04001ABA RID: 6842
			[Token(Token = "0x4001ABA")]
			[FieldOffset(Offset = "0x28")]
			[CanBeNull]
			public string Email;

			// Token: 0x04001ABB RID: 6843
			[Token(Token = "0x4001ABB")]
			[FieldOffset(Offset = "0x2C")]
			[CanBeNull]
			public string UserName;

			// Token: 0x04001ABC RID: 6844
			[Token(Token = "0x4001ABC")]
			[FieldOffset(Offset = "0x30")]
			[CanBeNull]
			public string Message;
		}
	}
}
