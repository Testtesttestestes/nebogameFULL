using System;
using Core.Data;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D56 RID: 3414
	[Token(Token = "0x2000D56")]
	public class AprsWindowArgs : BaseWindowArgs
	{
		// Token: 0x060053C0 RID: 21440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0xA17F", Offset = "0xA17F", VA = "0xA17F")]
		public AprsWindowArgs()
		{
		}

		// Token: 0x04002D64 RID: 11620
		[Token(Token = "0x4002D64")]
		[FieldOffset(Offset = "0x18")]
		public UserData Owner;

		// Token: 0x04002D65 RID: 11621
		[Token(Token = "0x4002D65")]
		[FieldOffset(Offset = "0x1C")]
		public UserData LoggedUser;

		// Token: 0x04002D66 RID: 11622
		[Token(Token = "0x4002D66")]
		[FieldOffset(Offset = "0x20")]
		public Predicate<AprData> CustomFilter;
	}
}
