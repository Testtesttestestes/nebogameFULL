using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E3 RID: 1763
	[Token(Token = "0x20006E3")]
	public class SellUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x17000807")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A60")]
			[Address(RVA = "0x7B03", Offset = "0x7B03", VA = "0x7B03", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x7B04", Offset = "0x7B04", VA = "0x7B04", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x7B05", Offset = "0x7B05", VA = "0x7B05", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x7B06", Offset = "0x7B06", VA = "0x7B06")]
		public SellUserArtifactContextMenuElement()
		{
		}
	}
}
