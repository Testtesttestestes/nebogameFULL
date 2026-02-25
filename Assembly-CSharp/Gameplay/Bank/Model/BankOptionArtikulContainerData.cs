using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C56 RID: 3158
	[Token(Token = "0x2000C56")]
	public class BankOptionArtikulContainerData
	{
		// Token: 0x06004CF6 RID: 19702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x9B32", Offset = "0x9B32", VA = "0x9B32")]
		public BankOptionArtikulContainerData()
		{
		}

		// Token: 0x04002A09 RID: 10761
		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0x8")]
		public ArtikulData ArtikulData;

		// Token: 0x04002A0A RID: 10762
		[Token(Token = "0x4002A0A")]
		[FieldOffset(Offset = "0xC")]
		public List<ArtikulData> ContainerArtikulData;
	}
}
