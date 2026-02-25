using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Inventory.Controller.Filters
{
	// Token: 0x020006C5 RID: 1733
	[Token(Token = "0x20006C5")]
	public class ArtifactTitleFilter : IArtifactFilter
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060029EB RID: 10731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E7")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60029EA")]
			[Address(RVA = "0x7A93", Offset = "0x7A93", VA = "0x7A93", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029EB")]
			[Address(RVA = "0x7A94", Offset = "0x7A94", VA = "0x7A94", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x7A95", Offset = "0x7A95", VA = "0x7A95", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x7A96", Offset = "0x7A96", VA = "0x7A96")]
		public ArtifactTitleFilter()
		{
		}
	}
}
