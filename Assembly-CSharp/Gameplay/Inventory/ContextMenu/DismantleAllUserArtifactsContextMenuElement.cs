using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006CC RID: 1740
	[Token(Token = "0x20006CC")]
	public class DismantleAllUserArtifactsContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x170007F1")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A09")]
			[Address(RVA = "0x7AAC", Offset = "0x7AAC", VA = "0x7AAC", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x7AAD", Offset = "0x7AAD", VA = "0x7AAD", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x7AAE", Offset = "0x7AAE", VA = "0x7AAE", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x7AAF", Offset = "0x7AAF", VA = "0x7AAF")]
		public DismantleAllUserArtifactsContextMenuElement()
		{
		}
	}
}
