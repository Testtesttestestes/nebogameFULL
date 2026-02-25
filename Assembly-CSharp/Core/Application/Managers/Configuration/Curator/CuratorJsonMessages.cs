using System;
using Il2CppDummyDll;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x02001271 RID: 4721
	[Token(Token = "0x2001271")]
	public class CuratorJsonMessages
	{
		// Token: 0x06007013 RID: 28691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007013")]
		[Address(RVA = "0xBA60", Offset = "0xBA60", VA = "0xBA60")]
		public CuratorJsonMessages()
		{
		}

		// Token: 0x02001272 RID: 4722
		[Token(Token = "0x2001272")]
		[Serializable]
		public class BootAns
		{
			// Token: 0x06007014 RID: 28692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007014")]
			[Address(RVA = "0xBA61", Offset = "0xBA61", VA = "0xBA61")]
			public BootAns()
			{
			}

			// Token: 0x04003A79 RID: 14969
			[Token(Token = "0x4003A79")]
			public const string ENDPOINT_PARAM_NAME = "endpoint";

			// Token: 0x04003A7A RID: 14970
			[Token(Token = "0x4003A7A")]
			public const string SERVER_PARAM_NAME = "server";

			// Token: 0x04003A7B RID: 14971
			[Token(Token = "0x4003A7B")]
			[FieldOffset(Offset = "0x8")]
			public string endpoint;

			// Token: 0x04003A7C RID: 14972
			[Token(Token = "0x4003A7C")]
			[FieldOffset(Offset = "0xC")]
			public string server;

			// Token: 0x04003A7D RID: 14973
			[Token(Token = "0x4003A7D")]
			[FieldOffset(Offset = "0x10")]
			public string client_ip;

			// Token: 0x04003A7E RID: 14974
			[Token(Token = "0x4003A7E")]
			[FieldOffset(Offset = "0x14")]
			public string country;
		}
	}
}
