using System;
using Com.TheFallenGames.OSA.Core;
using Gameplay.Bank.View;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.View.Picker
{
	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	public class BankOptionPickerOsaViewHolder : BaseItemViewsHolder
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x7011", Offset = "0x7011", VA = "0x7011", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x7012", Offset = "0x7012", VA = "0x7012")]
		public BankOptionPickerOsaViewHolder()
		{
		}

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x14")]
		public BankOptionListElement BankOption;
	}
}
