using System;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows
{
	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	public class DialogButtonsConfig : MonoBehaviour
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000210")]
		public DialogButtonsConfig.ButtonPrefabCfg[] ButtonPrefabs
		{
			[Token(Token = "0x6000EFE")]
			[Address(RVA = "0x614A", Offset = "0x614A", VA = "0x614A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x614B", Offset = "0x614B", VA = "0x614B")]
		public DialogButtonsConfig()
		{
		}

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DialogButtonsConfig.ButtonPrefabCfg[] _buttonPrefabs;

		// Token: 0x0200026F RID: 623
		[Token(Token = "0x200026F")]
		public enum ButtonColors
		{
			// Token: 0x0400078A RID: 1930
			[Token(Token = "0x400078A")]
			BLUE = 1,
			// Token: 0x0400078B RID: 1931
			[Token(Token = "0x400078B")]
			RED,
			// Token: 0x0400078C RID: 1932
			[Token(Token = "0x400078C")]
			GREEN
		}

		// Token: 0x02000270 RID: 624
		[Token(Token = "0x2000270")]
		[Serializable]
		public class ButtonPrefabCfg
		{
			// Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x614C", Offset = "0x614C", VA = "0x614C")]
			public ButtonPrefabCfg()
			{
			}

			// Token: 0x0400078D RID: 1933
			[Token(Token = "0x400078D")]
			[FieldOffset(Offset = "0x8")]
			public DialogButtonsConfig.ButtonColors ButtonColors;

			// Token: 0x0400078E RID: 1934
			[Token(Token = "0x400078E")]
			[FieldOffset(Offset = "0xC")]
			public Button ButtonPrefab;

			// Token: 0x0400078F RID: 1935
			[Token(Token = "0x400078F")]
			[FieldOffset(Offset = "0x10")]
			public ButtonWithCost ButtonWhitCostPrefab;
		}
	}
}
