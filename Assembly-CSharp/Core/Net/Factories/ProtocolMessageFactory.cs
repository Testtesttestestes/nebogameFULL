using System;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Il2CppDummyDll;

namespace Core.Net.Factories
{
	// Token: 0x02000EA2 RID: 3746
	[Token(Token = "0x2000EA2")]
	public class ProtocolMessageFactory<T> : IProtocolMessageFactory where T : IMessage, new()
	{
		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06005B08 RID: 23304 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x1700128A")]
		public int ServiceId
		{
			[Token(Token = "0x6005B08")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06005B09 RID: 23305 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x1700128B")]
		public int Id
		{
			[Token(Token = "0x6005B09")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B0A")]
		public ProtocolMessageFactory(int serviceId, int id)
		{
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B0B")]
		public IMessage CreateMessage()
		{
			return null;
		}
	}
}
