using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Inventory.Controller.Filters
{
	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x20006C4")]
	public class ArtifactSkillFilter : IArtifactFilter
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E6")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60029E6")]
			[Address(RVA = "0x7A8F", Offset = "0x7A8F", VA = "0x7A8F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029E7")]
			[Address(RVA = "0x7A90", Offset = "0x7A90", VA = "0x7A90", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x7A91", Offset = "0x7A91", VA = "0x7A91", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x7A92", Offset = "0x7A92", VA = "0x7A92")]
		public ArtifactSkillFilter()
		{
		}
	}
}
