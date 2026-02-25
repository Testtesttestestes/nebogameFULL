using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006CE RID: 1742
	[Token(Token = "0x20006CE")]
	public class DismantleArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x170007F3")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A11")]
			[Address(RVA = "0x7AB4", Offset = "0x7AB4", VA = "0x7AB4", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x7AB5", Offset = "0x7AB5", VA = "0x7AB5", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x7AB6", Offset = "0x7AB6", VA = "0x7AB6", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x7AB7", Offset = "0x7AB7", VA = "0x7AB7")]
		private void Dismantle(ArtifactData artifactData)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x7AB8", Offset = "0x7AB8", VA = "0x7AB8")]
		public DismantleArtifactContextMenuElement()
		{
		}
	}
}
