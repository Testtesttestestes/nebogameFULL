using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Net
{
	// Token: 0x02000E8D RID: 3725
	[Token(Token = "0x2000E8D")]
	public class ProtocolCommandInfoProvider
	{
		// Token: 0x06005A92 RID: 23186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0xA781", Offset = "0xA781", VA = "0xA781")]
		public void Add(Services service, Type index)
		{
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0xA782", Offset = "0xA782", VA = "0xA782")]
		public bool TryGetInfo(int service, out ProtocolCommandInfoProvider.IInfo result)
		{
			return default(bool);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A94")]
		[Address(RVA = "0xA783", Offset = "0xA783", VA = "0xA783")]
		public ProtocolCommandInfoProvider()
		{
		}

		// Token: 0x04003177 RID: 12663
		[Token(Token = "0x4003177")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<int, ProtocolCommandInfoProvider.IInfo> _infos;

		// Token: 0x02000E8E RID: 3726
		[Token(Token = "0x2000E8E")]
		public interface IInfo
		{
			// Token: 0x06005A95 RID: 23189
			[Token(Token = "0x6005A95")]
			string GetName(int value);
		}

		// Token: 0x02000E8F RID: 3727
		[Token(Token = "0x2000E8F")]
		public class Info : ProtocolCommandInfoProvider.IInfo
		{
			// Token: 0x06005A96 RID: 23190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A96")]
			[Address(RVA = "0xA784", Offset = "0xA784", VA = "0xA784")]
			public Info(Services service, Type index)
			{
			}

			// Token: 0x06005A97 RID: 23191 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A97")]
			[Address(RVA = "0xA785", Offset = "0xA785", VA = "0xA785", Slot = "4")]
			public string GetName(int value)
			{
				return null;
			}

			// Token: 0x04003178 RID: 12664
			[Token(Token = "0x4003178")]
			[FieldOffset(Offset = "0x8")]
			private readonly Services _service;

			// Token: 0x04003179 RID: 12665
			[Token(Token = "0x4003179")]
			[FieldOffset(Offset = "0xC")]
			private readonly Type _index;
		}
	}
}
