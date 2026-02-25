using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Auchan.Controller.Filters
{
	// Token: 0x02000CA1 RID: 3233
	[Token(Token = "0x2000CA1")]
	public class AuchanAvailableFilter : IAuchanItemFilter
	{
		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EAD RID: 20141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FEC")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6004EAC")]
			[Address(RVA = "0x9CDD", Offset = "0x9CDD", VA = "0x9CDD", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EAD")]
			[Address(RVA = "0x9CDE", Offset = "0x9CDE", VA = "0x9CDE", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x9CDF", Offset = "0x9CDF", VA = "0x9CDF", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x9CE0", Offset = "0x9CE0", VA = "0x9CE0")]
		public AuchanAvailableFilter()
		{
		}
	}
}
