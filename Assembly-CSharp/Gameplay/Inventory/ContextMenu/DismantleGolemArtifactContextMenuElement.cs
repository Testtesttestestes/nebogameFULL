using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x20006D0")]
	public class DismantleGolemArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x170007F4")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A18")]
			[Address(RVA = "0x7ABB", Offset = "0x7ABB", VA = "0x7ABB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x7ABC", Offset = "0x7ABC", VA = "0x7ABC", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x7ABD", Offset = "0x7ABD", VA = "0x7ABD", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x7ABE", Offset = "0x7ABE", VA = "0x7ABE")]
		public DismantleGolemArtifactContextMenuElement()
		{
		}
	}
}
