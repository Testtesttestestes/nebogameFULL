using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x20006D2")]
	public class EquipDollArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x170007F6")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A20")]
			[Address(RVA = "0x7AC3", Offset = "0x7AC3", VA = "0x7AC3", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x7AC4", Offset = "0x7AC4", VA = "0x7AC4", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x7AC5", Offset = "0x7AC5", VA = "0x7AC5", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x7AC6", Offset = "0x7AC6", VA = "0x7AC6")]
		public EquipDollArtifactContextMenuElement()
		{
		}
	}
}
