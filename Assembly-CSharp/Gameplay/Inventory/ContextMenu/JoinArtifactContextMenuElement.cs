using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D7 RID: 1751
	[Token(Token = "0x20006D7")]
	public class JoinArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x170007FB")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A34")]
			[Address(RVA = "0x7AD7", Offset = "0x7AD7", VA = "0x7AD7", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x7AD8", Offset = "0x7AD8", VA = "0x7AD8", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x7AD9", Offset = "0x7AD9", VA = "0x7AD9", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A37")]
		[Address(RVA = "0x7ADA", Offset = "0x7ADA", VA = "0x7ADA")]
		public JoinArtifactContextMenuElement()
		{
		}
	}
}
