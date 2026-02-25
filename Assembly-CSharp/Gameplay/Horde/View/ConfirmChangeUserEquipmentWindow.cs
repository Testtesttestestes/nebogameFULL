using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x20006F4")]
	public class ConfirmChangeUserEquipmentWindow : BaseDialogWindow<ConfirmChangeUserEquipmentWindow.ConfirmChangeUserEquipmentWindowArgs>
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000818")]
		public override string WindowId
		{
			[Token(Token = "0x6002AAB")]
			[Address(RVA = "0x7B46", Offset = "0x7B46", VA = "0x7B46", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x7B47", Offset = "0x7B47", VA = "0x7B47")]
		public static ConfirmChangeUserEquipmentWindow Show(params ArtifactData[] artifacts)
		{
			return null;
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x7B48", Offset = "0x7B48", VA = "0x7B48", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x7B49", Offset = "0x7B49", VA = "0x7B49")]
		public ConfirmChangeUserEquipmentWindow()
		{
		}

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Horde/ConfirmChangeUserEquipmentWindow";

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x020006F5 RID: 1781
		[Token(Token = "0x20006F5")]
		public class ConfirmChangeUserEquipmentWindowArgs : BaseDialogWindow<ConfirmChangeUserEquipmentWindow.ConfirmChangeUserEquipmentWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002AAF RID: 10927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AAF")]
			[Address(RVA = "0x7B4A", Offset = "0x7B4A", VA = "0x7B4A")]
			public ConfirmChangeUserEquipmentWindowArgs(ArtifactData[] artifacts)
			{
			}

			// Token: 0x0400174C RID: 5964
			[Token(Token = "0x400174C")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;
		}
	}
}
