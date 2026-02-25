using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	public class InfoArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x170007FA")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A30")]
			[Address(RVA = "0x7AD3", Offset = "0x7AD3", VA = "0x7AD3", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x7AD4", Offset = "0x7AD4", VA = "0x7AD4", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x7AD5", Offset = "0x7AD5", VA = "0x7AD5", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x7AD6", Offset = "0x7AD6", VA = "0x7AD6")]
		public InfoArtifactContextMenuElement()
		{
		}
	}
}
