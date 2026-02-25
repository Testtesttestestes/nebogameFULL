using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	public class EquipArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x170007F7")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A24")]
			[Address(RVA = "0x7AC7", Offset = "0x7AC7", VA = "0x7AC7", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x7AC8", Offset = "0x7AC8", VA = "0x7AC8", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x7AC9", Offset = "0x7AC9", VA = "0x7AC9", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x7ACA", Offset = "0x7ACA", VA = "0x7ACA")]
		public EquipArtifactContextMenuElement()
		{
		}
	}
}
