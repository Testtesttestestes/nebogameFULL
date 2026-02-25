using System;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Bag
{
	// Token: 0x02000698 RID: 1688
	[Token(Token = "0x2000698")]
	public interface IInventoryBagSlotView
	{
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060028C7 RID: 10439
		// (set) Token: 0x060028C8 RID: 10440
		[Token(Token = "0x170007B7")]
		int SlotId { [Token(Token = "0x60028C7")] get; [Token(Token = "0x60028C8")] set; }

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060028C9 RID: 10441
		// (set) Token: 0x060028CA RID: 10442
		[Token(Token = "0x170007B8")]
		ArtifactData ArtifactData { [Token(Token = "0x60028C9")] get; [Token(Token = "0x60028CA")] set; }
	}
}
