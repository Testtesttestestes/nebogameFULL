using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000613 RID: 1555
	[Token(Token = "0x2000613")]
	public class MedalSkillFilter : IMedalFilter
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000718")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025C5")]
			[Address(RVA = "0x7703", Offset = "0x7703", VA = "0x7703", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025C6")]
			[Address(RVA = "0x7704", Offset = "0x7704", VA = "0x7704", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x7705", Offset = "0x7705", VA = "0x7705", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x7706", Offset = "0x7706", VA = "0x7706")]
		public MedalSkillFilter()
		{
		}
	}
}
