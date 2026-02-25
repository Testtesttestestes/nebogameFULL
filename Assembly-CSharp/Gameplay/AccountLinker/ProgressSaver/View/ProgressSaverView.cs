using System;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using TMPro;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.AccountLinker.ProgressSaver.View
{
	// Token: 0x02000E0A RID: 3594
	[Token(Token = "0x2000E0A")]
	public class ProgressSaverView : MonoBehaviour
	{
		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600578B RID: 22411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011DD")]
		public TabBar TabBar
		{
			[Token(Token = "0x600578B")]
			[Address(RVA = "0xA506", Offset = "0xA506", VA = "0xA506")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600578C RID: 22412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011DE")]
		public SignInVariants SignInVariants
		{
			[Token(Token = "0x600578C")]
			[Address(RVA = "0xA507", Offset = "0xA507", VA = "0xA507")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x0600578D RID: 22413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011DF")]
		public TextMeshProUGUI PlatformNick
		{
			[Token(Token = "0x600578D")]
			[Address(RVA = "0xA508", Offset = "0xA508", VA = "0xA508")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011E0")]
		public TextMeshProUGUI EmailPassButtonLabel
		{
			[Token(Token = "0x600578E")]
			[Address(RVA = "0xA509", Offset = "0xA509", VA = "0xA509")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600578F RID: 22415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011E1")]
		public TextMeshProUGUI StatusMessage
		{
			[Token(Token = "0x600578F")]
			[Address(RVA = "0xA50A", Offset = "0xA50A", VA = "0xA50A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005790")]
		[Address(RVA = "0xA50B", Offset = "0xA50B", VA = "0xA50B")]
		public ProgressSaverView()
		{
		}

		// Token: 0x04002F75 RID: 12149
		[Token(Token = "0x4002F75")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04002F76 RID: 12150
		[Token(Token = "0x4002F76")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SignInVariants _signInVariants;

		// Token: 0x04002F77 RID: 12151
		[Token(Token = "0x4002F77")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _emailPassButtonLabel;

		// Token: 0x04002F78 RID: 12152
		[Token(Token = "0x4002F78")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _platformNick;

		// Token: 0x04002F79 RID: 12153
		[Token(Token = "0x4002F79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _statusMessage;
	}
}
