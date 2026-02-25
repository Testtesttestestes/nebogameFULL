using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D8 RID: 1752
	[Token(Token = "0x20006D8")]
	public class MoveToNebomarketContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x170007FC")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A38")]
			[Address(RVA = "0x7ADB", Offset = "0x7ADB", VA = "0x7ADB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x7ADC", Offset = "0x7ADC", VA = "0x7ADC", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x7ADD", Offset = "0x7ADD", VA = "0x7ADD", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x7ADE", Offset = "0x7ADE", VA = "0x7ADE")]
		public MoveToNebomarketContextMenuElement()
		{
		}
	}
}
