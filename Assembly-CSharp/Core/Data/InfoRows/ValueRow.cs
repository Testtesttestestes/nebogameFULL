using System;
using Core.Data.Balance;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace Core.Data.InfoRows
{
	// Token: 0x020010E0 RID: 4320
	[Token(Token = "0x20010E0")]
	public class ValueRow : CommonRow
	{
		// Token: 0x06006520 RID: 25888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006520")]
		[Address(RVA = "0x215F", Offset = "0x215F", VA = "0x215F")]
		public ValueRow()
		{
		}

		// Token: 0x04003601 RID: 13825
		[Token(Token = "0x4003601")]
		[FieldOffset(Offset = "0x10")]
		public bool? IsValid;

		// Token: 0x04003602 RID: 13826
		[Token(Token = "0x4003602")]
		[FieldOffset(Offset = "0x14")]
		public string IconAssetId;

		// Token: 0x04003603 RID: 13827
		[Token(Token = "0x4003603")]
		[FieldOffset(Offset = "0x18")]
		public string Value;

		// Token: 0x04003604 RID: 13828
		[Token(Token = "0x4003604")]
		[FieldOffset(Offset = "0x1C")]
		public Color32 ValueColor;

		// Token: 0x04003605 RID: 13829
		[Token(Token = "0x4003605")]
		[FieldOffset(Offset = "0x20")]
		public ResourceSet Price;

		// Token: 0x04003606 RID: 13830
		[Token(Token = "0x4003606")]
		[FieldOffset(Offset = "0x28")]
		public long ManaPrice;

		// Token: 0x04003607 RID: 13831
		[Token(Token = "0x4003607")]
		[FieldOffset(Offset = "0x30")]
		public UserData User;

		// Token: 0x04003608 RID: 13832
		[Token(Token = "0x4003608")]
		[FieldOffset(Offset = "0x34")]
		public IBalanceSource BalanceSource;
	}
}
