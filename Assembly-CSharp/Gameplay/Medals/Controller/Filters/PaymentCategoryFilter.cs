using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	public class PaymentCategoryFilter : IMedalFilter
	{
		// Token: 0x060025CD RID: 9677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x770B", Offset = "0x770B", VA = "0x770B")]
		public PaymentCategoryFilter()
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071A")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025CE")]
			[Address(RVA = "0x770C", Offset = "0x770C", VA = "0x770C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025CF")]
			[Address(RVA = "0x770D", Offset = "0x770D", VA = "0x770D", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x770E", Offset = "0x770E", VA = "0x770E")]
		public void UpdateLastMedalToShow(MedalData medalData)
		{
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x770F", Offset = "0x770F", VA = "0x770F", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x8")]
		private uint _categoryId;

		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0xC")]
		private uint _sortOrder;
	}
}
