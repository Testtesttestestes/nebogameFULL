using System;
using System.Collections.Generic;
using Core.Net.Connection;
using Core.Net.Factories;
using Google.Protobuf;
using Il2CppDummyDll;

namespace Core
{
	// Token: 0x02000E5F RID: 3679
	[Token(Token = "0x2000E5F")]
	public class ProtocolMessageFactoriesRepository : IProtocolMessageFactoriesRepository
	{
		// Token: 0x060059FA RID: 23034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059FA")]
		[Address(RVA = "0xA70D", Offset = "0xA70D", VA = "0xA70D")]
		private string GetKey(int serviceId, uint eventId)
		{
			return null;
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FB")]
		public void Add<T>(int serviceId, uint id) where T : IMessage, new()
		{
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FC")]
		[Address(RVA = "0xA70E", Offset = "0xA70E", VA = "0xA70E")]
		public void Add(int serviceId, uint id, IProtocolMessageFactory factory)
		{
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x0000FF30 File Offset: 0x0000E130
		[Token(Token = "0x60059FD")]
		[Address(RVA = "0xA70F", Offset = "0xA70F", VA = "0xA70F", Slot = "4")]
		public bool TryGetFactory(int serviceId, uint id, out IProtocolMessageFactory factory)
		{
			return default(bool);
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FE")]
		[Address(RVA = "0xA710", Offset = "0xA710", VA = "0xA710")]
		public ProtocolMessageFactoriesRepository()
		{
		}

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, IProtocolMessageFactory> Factories;
	}
}
