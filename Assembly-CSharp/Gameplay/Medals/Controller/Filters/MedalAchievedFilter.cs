using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000610 RID: 1552
	[Token(Token = "0x2000610")]
	public class MedalAchievedFilter : IMedalFilter
	{
		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000715")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025B9")]
			[Address(RVA = "0x76F7", Offset = "0x76F7", VA = "0x76F7", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025BA")]
			[Address(RVA = "0x76F8", Offset = "0x76F8", VA = "0x76F8", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x76F9", Offset = "0x76F9", VA = "0x76F9", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x76FA", Offset = "0x76FA", VA = "0x76FA")]
		public MedalAchievedFilter()
		{
		}
	}
}
