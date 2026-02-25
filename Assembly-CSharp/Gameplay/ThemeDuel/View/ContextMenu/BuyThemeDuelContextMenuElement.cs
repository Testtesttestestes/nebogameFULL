using System;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.ThemeDuel.View.ContextMenu
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	public class BuyThemeDuelContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x1700056E")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6001DE7")]
			[Address(RVA = "0x6F65", Offset = "0x6F65", VA = "0x6F65", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x6F66", Offset = "0x6F66", VA = "0x6F66", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x6F67", Offset = "0x6F67", VA = "0x6F67", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x6F68", Offset = "0x6F68", VA = "0x6F68")]
		public BuyThemeDuelContextMenuElement()
		{
		}
	}
}
