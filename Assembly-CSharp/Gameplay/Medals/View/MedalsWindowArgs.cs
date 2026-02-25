using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Medals.View
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	public class MedalsWindowArgs : BaseWindowArgs
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x767E", Offset = "0x767E", VA = "0x767E")]
		public MedalsWindowArgs()
		{
		}

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0x18")]
		public UserData Owner;

		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0x1C")]
		public UserData LoggedUser;

		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x20")]
		public Predicate<MedalData> CustomFilter;
	}
}
