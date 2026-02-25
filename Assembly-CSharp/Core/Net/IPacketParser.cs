using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net
{
	// Token: 0x02000E87 RID: 3719
	[Token(Token = "0x2000E87")]
	public interface IPacketParser
	{
		// Token: 0x14000221 RID: 545
		// (add) Token: 0x06005A7B RID: 23163
		// (remove) Token: 0x06005A7C RID: 23164
		[Token(Token = "0x14000221")]
		event Action<PacketParser.Packet> CompleteEvent;

		// Token: 0x06005A7D RID: 23165
		[Token(Token = "0x6005A7D")]
		byte[] Serialize([NotNull] SrvCommand command);

		// Token: 0x06005A7E RID: 23166
		[Token(Token = "0x6005A7E")]
		[NotNull]
		IList<PacketParser.Packet> Deserialize(byte[] bytes);

		// Token: 0x06005A7F RID: 23167
		[Token(Token = "0x6005A7F")]
		void Reset();
	}
}
