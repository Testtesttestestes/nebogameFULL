using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Inventory.Controller.Filters
{
	// Token: 0x020006C6 RID: 1734
	[Token(Token = "0x20006C6")]
	public interface IArtifactFilter
	{
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060029EE RID: 10734
		// (set) Token: 0x060029EF RID: 10735
		[Token(Token = "0x170007E8")]
		FilterInfo FilterInfo { [Token(Token = "0x60029EE")] get; [Token(Token = "0x60029EF")] set; }

		// Token: 0x060029F0 RID: 10736
		[Token(Token = "0x60029F0")]
		bool Filter(ArtifactData artifactData);
	}
}
