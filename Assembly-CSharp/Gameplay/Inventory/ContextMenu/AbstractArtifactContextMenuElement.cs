using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006C7 RID: 1735
	[Token(Token = "0x20006C7")]
	public abstract class AbstractArtifactContextMenuElement
	{
		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060029F1 RID: 10737
		[Token(Token = "0x170007E9")]
		public abstract ArtikulMenuActionDic.Types.Actions ActionId { [Token(Token = "0x60029F1")] get; }

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007EA")]
		public string Title
		{
			[Token(Token = "0x60029F2")]
			[Address(RVA = "0x7A97", Offset = "0x7A97", VA = "0x7A97")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x170007EB")]
		public uint Position
		{
			[Token(Token = "0x60029F3")]
			[Address(RVA = "0x7A98", Offset = "0x7A98", VA = "0x7A98")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007EC")]
		public string IconAssetId
		{
			[Token(Token = "0x60029F4")]
			[Address(RVA = "0x7A99", Offset = "0x7A99", VA = "0x7A99")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029F5 RID: 10741
		[Token(Token = "0x60029F5")]
		public abstract bool Validate(IArtifactView artifactView);

		// Token: 0x060029F6 RID: 10742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x7A9A", Offset = "0x7A9A", VA = "0x7A9A", Slot = "6")]
		public virtual void Setup(IArtifactView artifactView)
		{
		}

		// Token: 0x060029F7 RID: 10743
		[Token(Token = "0x60029F7")]
		public abstract void Handle(IArtifactView artifactView);

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x7A9B", Offset = "0x7A9B", VA = "0x7A9B")]
		protected AbstractArtifactContextMenuElement()
		{
		}

		// Token: 0x0400173A RID: 5946
		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0x8")]
		protected string _title;

		// Token: 0x0400173B RID: 5947
		[Token(Token = "0x400173B")]
		[FieldOffset(Offset = "0xC")]
		protected uint _position;

		// Token: 0x0400173C RID: 5948
		[Token(Token = "0x400173C")]
		[FieldOffset(Offset = "0x10")]
		protected string _iconAssetId;

		// Token: 0x0400173D RID: 5949
		[Token(Token = "0x400173D")]
		[FieldOffset(Offset = "0x14")]
		private ArtikulMenuActionDic _artikulMenuActionDic;

		// Token: 0x0400173E RID: 5950
		[Token(Token = "0x400173E")]
		[FieldOffset(Offset = "0x18")]
		private ArtikulTypeMenuActionDic _artikulTypeMenuActionDic;
	}
}
