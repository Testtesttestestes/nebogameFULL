using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Auchan.Controller.Filters
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	public class AuchanTitleFilter : IAuchanItemFilter
	{
		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FED")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6004EB0")]
			[Address(RVA = "0x9CE1", Offset = "0x9CE1", VA = "0x9CE1", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EB1")]
			[Address(RVA = "0x9CE2", Offset = "0x9CE2", VA = "0x9CE2", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x9CE3", Offset = "0x9CE3", VA = "0x9CE3", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x9CE4", Offset = "0x9CE4", VA = "0x9CE4")]
		public AuchanTitleFilter()
		{
		}
	}
}
