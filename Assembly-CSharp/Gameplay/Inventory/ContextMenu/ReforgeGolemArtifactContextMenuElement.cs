using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DD RID: 1757
	[Token(Token = "0x20006DD")]
	public class ReforgeGolemArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x17000801")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A48")]
			[Address(RVA = "0x7AEB", Offset = "0x7AEB", VA = "0x7AEB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6002A49")]
		[Address(RVA = "0x7AEC", Offset = "0x7AEC", VA = "0x7AEC", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x7AED", Offset = "0x7AED", VA = "0x7AED", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4B")]
		[Address(RVA = "0x7AEE", Offset = "0x7AEE", VA = "0x7AEE")]
		public ReforgeGolemArtifactContextMenuElement()
		{
		}
	}
}
