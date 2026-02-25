using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Auchan.Controller.Filters
{
	// Token: 0x02000CA3 RID: 3235
	[Token(Token = "0x2000CA3")]
	public interface IAuchanItemFilter
	{
		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06004EB4 RID: 20148
		// (set) Token: 0x06004EB5 RID: 20149
		[Token(Token = "0x17000FEE")]
		FilterInfo FilterInfo { [Token(Token = "0x6004EB4")] get; [Token(Token = "0x6004EB5")] set; }

		// Token: 0x06004EB6 RID: 20150
		[Token(Token = "0x6004EB6")]
		bool Filter(ArtifactData artifactData);
	}
}
