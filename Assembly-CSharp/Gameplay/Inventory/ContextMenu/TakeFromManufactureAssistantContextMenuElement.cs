using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E6 RID: 1766
	[Token(Token = "0x20006E6")]
	public class TakeFromManufactureAssistantContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x1700080A")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A6D")]
			[Address(RVA = "0x7B10", Offset = "0x7B10", VA = "0x7B10", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x7B11", Offset = "0x7B11", VA = "0x7B11", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0x7B12", Offset = "0x7B12", VA = "0x7B12", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x7B13", Offset = "0x7B13", VA = "0x7B13")]
		public TakeFromManufactureAssistantContextMenuElement()
		{
		}
	}
}
