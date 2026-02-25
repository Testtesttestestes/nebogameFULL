using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	public class ConfirmDeleteCraftSchemeWindow : BaseDialogWindow<ConfirmDeleteCraftSchemeWindow.ConfirmDeleteCraftSchemeWindowArgs>
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000220")]
		public override string WindowId
		{
			[Token(Token = "0x6000F5A")]
			[Address(RVA = "0x6185", Offset = "0x6185", VA = "0x6185", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x6186", Offset = "0x6186", VA = "0x6186", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x6187", Offset = "0x6187", VA = "0x6187")]
		public static ConfirmDeleteCraftSchemeWindow Show(CraftSchemeData craftScheme, Action<CraftSchemeData> resultCallback)
		{
			return null;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x6188", Offset = "0x6188", VA = "0x6188")]
		public ConfirmDeleteCraftSchemeWindow()
		{
		}

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/ConfirmDeleteCraftSchemeWindow";

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtikulView _artifactViewPrefab;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _quantity;

		// Token: 0x0200028C RID: 652
		[Token(Token = "0x200028C")]
		public class ConfirmDeleteCraftSchemeWindowArgs : BaseDialogWindow<ConfirmDeleteCraftSchemeWindow.ConfirmDeleteCraftSchemeWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F5E RID: 3934 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x6189", Offset = "0x6189", VA = "0x6189")]
			public ConfirmDeleteCraftSchemeWindowArgs(CraftSchemeData craftScheme)
			{
			}

			// Token: 0x06000F5F RID: 3935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F5F")]
			[Address(RVA = "0x618A", Offset = "0x618A", VA = "0x618A")]
			private void InitInstance()
			{
			}

			// Token: 0x040007D1 RID: 2001
			[Token(Token = "0x40007D1")]
			[FieldOffset(Offset = "0x2C")]
			public readonly CraftSchemeData CraftScheme;
		}
	}
}
