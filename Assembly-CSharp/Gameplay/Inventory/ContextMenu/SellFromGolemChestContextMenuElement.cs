using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E2 RID: 1762
	[Token(Token = "0x20006E2")]
	public class SellFromGolemChestContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x17000806")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A5C")]
			[Address(RVA = "0x7AFF", Offset = "0x7AFF", VA = "0x7AFF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x7B00", Offset = "0x7B00", VA = "0x7B00", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x7B01", Offset = "0x7B01", VA = "0x7B01", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x7B02", Offset = "0x7B02", VA = "0x7B02")]
		public SellFromGolemChestContextMenuElement()
		{
		}
	}
}
