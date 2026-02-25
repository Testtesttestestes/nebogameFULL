using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D5 RID: 1749
	[Token(Token = "0x20006D5")]
	public class FromFavoritesArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x170007F9")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A2C")]
			[Address(RVA = "0x7ACF", Offset = "0x7ACF", VA = "0x7ACF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x7AD0", Offset = "0x7AD0", VA = "0x7AD0", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x7AD1", Offset = "0x7AD1", VA = "0x7AD1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x7AD2", Offset = "0x7AD2", VA = "0x7AD2")]
		public FromFavoritesArtifactContextMenuElement()
		{
		}
	}
}
