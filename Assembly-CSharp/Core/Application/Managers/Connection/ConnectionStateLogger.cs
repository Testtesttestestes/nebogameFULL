using System;
using Core.Gameplay.Managers.Configuration;
using Core.Net.Connection;
using Il2CppDummyDll;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001267 RID: 4711
	[Token(Token = "0x2001267")]
	public class ConnectionStateLogger
	{
		// Token: 0x06006FC9 RID: 28617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FC9")]
		[Address(RVA = "0xBA2A", Offset = "0xBA2A", VA = "0xBA2A")]
		private string Wrap(string value, ConnectionState state)
		{
			return null;
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0xBA2B", Offset = "0xBA2B", VA = "0xBA2B")]
		public void Log(ConfigRecord config, IConnection connection)
		{
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0xBA2C", Offset = "0xBA2C", VA = "0xBA2C")]
		public void Log(ConnectionState state, IConnection connection)
		{
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0xBA2D", Offset = "0xBA2D", VA = "0xBA2D")]
		public void Log(string value, ConnectionState state)
		{
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0xBA2E", Offset = "0xBA2E", VA = "0xBA2E")]
		public ConnectionStateLogger()
		{
		}

		// Token: 0x04003A62 RID: 14946
		[Token(Token = "0x4003A62")]
		public const string IDLE_COLOR = "teal";

		// Token: 0x04003A63 RID: 14947
		[Token(Token = "0x4003A63")]
		public const string WARNING_COLOR = "purple";
	}
}
