using System;
using Gameplay.Ad.EnergyRegenAd.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Windows;
using UnityEngine;

namespace UI
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public class NotEnoughResourcesWindow : BaseDialogWindow<NotEnoughResourcesWindow.NotEnoughResourcesWindowArgs>
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010E")]
		public override string WindowId
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x5C1B", Offset = "0x5C1B", VA = "0x5C1B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x5C1C", Offset = "0x5C1C", VA = "0x5C1C", Slot = "22")]
		protected override void OnShow(NotEnoughResourcesWindow.NotEnoughResourcesWindowArgs args)
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5C1D", Offset = "0x5C1D", VA = "0x5C1D")]
		public NotEnoughResourcesWindow()
		{
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/NotEnoughResourcesWindow";

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private EnergyRegenAdEntryView _energyRegenAdEntryView;

		// Token: 0x02000105 RID: 261
		[Token(Token = "0x2000105")]
		public class NotEnoughResourcesWindowArgs : BaseDialogWindow<NotEnoughResourcesWindow.NotEnoughResourcesWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x5C1E", Offset = "0x5C1E", VA = "0x5C1E")]
			public NotEnoughResourcesWindowArgs(Protocol.Consts.Resources resourceId)
			{
			}

			// Token: 0x04000303 RID: 771
			[Token(Token = "0x4000303")]
			[FieldOffset(Offset = "0x2C")]
			public Protocol.Consts.Resources ResourceId;
		}
	}
}
