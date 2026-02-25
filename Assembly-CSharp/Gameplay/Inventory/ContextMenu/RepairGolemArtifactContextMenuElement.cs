using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x20006DF")]
	public class RepairGolemArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x17000803")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A50")]
			[Address(RVA = "0x7AF3", Offset = "0x7AF3", VA = "0x7AF3", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6002A51")]
		[Address(RVA = "0x7AF4", Offset = "0x7AF4", VA = "0x7AF4", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x7AF5", Offset = "0x7AF5", VA = "0x7AF5", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x7AF6", Offset = "0x7AF6", VA = "0x7AF6")]
		public RepairGolemArtifactContextMenuElement()
		{
		}
	}
}
