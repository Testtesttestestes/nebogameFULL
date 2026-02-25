using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace UI
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	public class PortalsInfoWindow : BaseDialogWindow<PortalsInfoWindow.PortalsInfoWindowArgs>
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000115")]
		public override string WindowId
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x5C2E", Offset = "0x5C2E", VA = "0x5C2E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x5C2F", Offset = "0x5C2F", VA = "0x5C2F", Slot = "27")]
		protected override void HandleDescription()
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x5C30", Offset = "0x5C30", VA = "0x5C30", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x5C31", Offset = "0x5C31", VA = "0x5C31")]
		public PortalsInfoWindow()
		{
		}

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameRawImage _decorIcon;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _counterTitle;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _counterValue;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Portals/PortalsInfoWindow";

		// Token: 0x0200010F RID: 271
		[Token(Token = "0x200010F")]
		public class PortalsInfoWindowArgs : BaseDialogWindow<PortalsInfoWindow.PortalsInfoWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000116 RID: 278
			// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000116")]
			public string DecorIconAsset
			{
				[Token(Token = "0x60008A2")]
				[Address(RVA = "0x5C32", Offset = "0x5C32", VA = "0x5C32")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000117")]
			public string CounterTitle
			{
				[Token(Token = "0x60008A3")]
				[Address(RVA = "0x5C33", Offset = "0x5C33", VA = "0x5C33")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000118")]
			public string CounterValue
			{
				[Token(Token = "0x60008A4")]
				[Address(RVA = "0x5C34", Offset = "0x5C34", VA = "0x5C34")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x5C35", Offset = "0x5C35", VA = "0x5C35")]
			public PortalsInfoWindowArgs(PortalsModel portalsModel, string description, string counterTitle, string counterValue)
			{
			}
		}
	}
}
