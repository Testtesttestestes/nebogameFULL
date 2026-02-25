using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Competition;
using Protocol.Dic;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F0 RID: 2288
	[Token(Token = "0x20008F0")]
	public class CompetitionData
	{
		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060035EF RID: 13807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB4")]
		public CompetitionInfo Info
		{
			[Token(Token = "0x60035EE")]
			[Address(RVA = "0x85FB", Offset = "0x85FB", VA = "0x85FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035EF")]
			[Address(RVA = "0x85FC", Offset = "0x85FC", VA = "0x85FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x85FD", Offset = "0x85FD", VA = "0x85FD")]
		public CompetitionData([NotNull] CompetitionDic dict, [NotNull] CompetitionInfo info)
		{
		}

		// Token: 0x04001D91 RID: 7569
		[Token(Token = "0x4001D91")]
		[FieldOffset(Offset = "0x8")]
		[NotNull]
		public readonly CompetitionDic Dict;
	}
}
