using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	public class EquipArtifactFromDropContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x170007F5")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A1C")]
			[Address(RVA = "0x7ABF", Offset = "0x7ABF", VA = "0x7ABF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x7AC0", Offset = "0x7AC0", VA = "0x7AC0", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x7AC1", Offset = "0x7AC1", VA = "0x7AC1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x7AC2", Offset = "0x7AC2", VA = "0x7AC2")]
		public EquipArtifactFromDropContextMenuElement()
		{
		}
	}
}
