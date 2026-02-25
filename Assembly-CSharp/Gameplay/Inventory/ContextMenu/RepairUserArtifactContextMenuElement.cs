using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	public class RepairUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x17000804")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A54")]
			[Address(RVA = "0x7AF7", Offset = "0x7AF7", VA = "0x7AF7", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x7AF8", Offset = "0x7AF8", VA = "0x7AF8", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x7AF9", Offset = "0x7AF9", VA = "0x7AF9", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x7AFA", Offset = "0x7AFA", VA = "0x7AFA")]
		public RepairUserArtifactContextMenuElement()
		{
		}
	}
}
