using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C3A RID: 3130
	[Token(Token = "0x2000C3A")]
	public class BankOptionInfoWindowArgs : BaseWindowArgs
	{
		// Token: 0x06004C4F RID: 19535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x9A92", Offset = "0x9A92", VA = "0x9A92")]
		public BankOptionInfoWindowArgs()
		{
		}

		// Token: 0x0400299F RID: 10655
		[Token(Token = "0x400299F")]
		[FieldOffset(Offset = "0x18")]
		public BankOptionViewArgs BankOptionDataWrapper;
	}
}
