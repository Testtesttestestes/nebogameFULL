using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	public class MedalPriceFilter : IMedalFilter
	{
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000717")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025C1")]
			[Address(RVA = "0x76FF", Offset = "0x76FF", VA = "0x76FF", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025C2")]
			[Address(RVA = "0x7700", Offset = "0x7700", VA = "0x7700", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x7701", Offset = "0x7701", VA = "0x7701", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x7702", Offset = "0x7702", VA = "0x7702")]
		public MedalPriceFilter()
		{
		}
	}
}
