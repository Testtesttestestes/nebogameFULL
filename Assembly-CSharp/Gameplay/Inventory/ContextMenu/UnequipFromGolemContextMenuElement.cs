using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EF RID: 1775
	[Token(Token = "0x20006EF")]
	public class UnequipFromGolemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x17000813")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A91")]
			[Address(RVA = "0x7B34", Offset = "0x7B34", VA = "0x7B34", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x7B35", Offset = "0x7B35", VA = "0x7B35", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x7B36", Offset = "0x7B36", VA = "0x7B36", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x7B37", Offset = "0x7B37", VA = "0x7B37")]
		public UnequipFromGolemContextMenuElement()
		{
		}
	}
}
