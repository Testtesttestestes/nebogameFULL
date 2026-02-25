using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	public class MedalTitleFilter : IMedalFilter
	{
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000719")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025C9")]
			[Address(RVA = "0x7707", Offset = "0x7707", VA = "0x7707", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025CA")]
			[Address(RVA = "0x7708", Offset = "0x7708", VA = "0x7708", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x7709", Offset = "0x7709", VA = "0x7709", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x770A", Offset = "0x770A", VA = "0x770A")]
		public MedalTitleFilter()
		{
		}
	}
}
