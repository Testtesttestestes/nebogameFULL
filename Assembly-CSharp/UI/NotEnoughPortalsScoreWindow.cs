using System;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	public class NotEnoughPortalsScoreWindow : BaseDialogWindow<NotEnoughPortalsScoreWindow.NotEnoughPortalsScoreWindowArgs>
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010D")]
		public override string WindowId
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x5C14", Offset = "0x5C14", VA = "0x5C14", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x5C15", Offset = "0x5C15", VA = "0x5C15", Slot = "27")]
		protected override void HandleDescription()
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x5C16", Offset = "0x5C16", VA = "0x5C16")]
		private void Start()
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x5C17", Offset = "0x5C17", VA = "0x5C17")]
		private void Close()
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x5C18", Offset = "0x5C18", VA = "0x5C18", Slot = "29")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x5C19", Offset = "0x5C19", VA = "0x5C19")]
		public NotEnoughPortalsScoreWindow()
		{
		}

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _okButton;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Portals/NotEnoughPortalsScoreWindow";

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		public class NotEnoughPortalsScoreWindowArgs : BaseDialogWindow<NotEnoughPortalsScoreWindow.NotEnoughPortalsScoreWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x5C1A", Offset = "0x5C1A", VA = "0x5C1A")]
			public NotEnoughPortalsScoreWindowArgs(PortalsModel portalsModel)
			{
			}
		}
	}
}
