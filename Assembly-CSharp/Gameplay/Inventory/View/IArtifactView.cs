using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol;
using UnityEngine;
using Utils;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	public interface IArtifactView
	{
		// Token: 0x14000153 RID: 339
		// (add) Token: 0x060027AC RID: 10156
		// (remove) Token: 0x060027AD RID: 10157
		[Token(Token = "0x14000153")]
		event Action DataChangedEvent;

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060027AE RID: 10158
		[Token(Token = "0x17000781")]
		ArtifactData ArtifactData { [Token(Token = "0x60027AE")] get; }

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060027AF RID: 10159
		// (set) Token: 0x060027B0 RID: 10160
		[Token(Token = "0x17000782")]
		ArtifactView.ArtifactViewArgs Args { [Token(Token = "0x60027AF")] get; [Token(Token = "0x60027B0")] set; }

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060027B1 RID: 10161
		[Token(Token = "0x17000783")]
		GameObject GameObject { [Token(Token = "0x60027B1")] get; }

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060027B2 RID: 10162
		[Token(Token = "0x17000784")]
		IActionInfo Info { [Token(Token = "0x60027B2")] get; }

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060027B3 RID: 10163
		[Token(Token = "0x17000785")]
		BackTime Backtime { [Token(Token = "0x60027B3")] get; }

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060027B4 RID: 10164
		[Token(Token = "0x17000786")]
		bool OnlyMarketAccount { [Token(Token = "0x60027B4")] get; }
	}
}
