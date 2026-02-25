using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Inventory.Controller.Filters
{
	// Token: 0x020006C3 RID: 1731
	[Token(Token = "0x20006C3")]
	public class ArtifactLevelFilter : IArtifactFilter
	{
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E5")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60029E2")]
			[Address(RVA = "0x7A8B", Offset = "0x7A8B", VA = "0x7A8B", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029E3")]
			[Address(RVA = "0x7A8C", Offset = "0x7A8C", VA = "0x7A8C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x7A8D", Offset = "0x7A8D", VA = "0x7A8D", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x7A8E", Offset = "0x7A8E", VA = "0x7A8E")]
		public ArtifactLevelFilter()
		{
		}
	}
}
