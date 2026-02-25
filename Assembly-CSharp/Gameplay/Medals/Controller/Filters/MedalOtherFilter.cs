using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	public class MedalOtherFilter : IMedalFilter
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000716")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025BD")]
			[Address(RVA = "0x76FB", Offset = "0x76FB", VA = "0x76FB", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025BE")]
			[Address(RVA = "0x76FC", Offset = "0x76FC", VA = "0x76FC", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x76FD", Offset = "0x76FD", VA = "0x76FD", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x76FE", Offset = "0x76FE", VA = "0x76FE")]
		public MedalOtherFilter()
		{
		}
	}
}
