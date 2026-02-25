using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D9 RID: 1753
	[Token(Token = "0x20006D9")]
	public class MoveToShopContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x170007FD")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A3C")]
			[Address(RVA = "0x7ADF", Offset = "0x7ADF", VA = "0x7ADF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x7AE0", Offset = "0x7AE0", VA = "0x7AE0", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x7AE1", Offset = "0x7AE1", VA = "0x7AE1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x7AE2", Offset = "0x7AE2", VA = "0x7AE2")]
		public MoveToShopContextMenuElement()
		{
		}
	}
}
