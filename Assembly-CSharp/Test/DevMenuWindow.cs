using System;
using Core.Analytics.Service.Android;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations;
using UI.Windows;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Test
{
	// Token: 0x02000E41 RID: 3649
	[Token(Token = "0x2000E41")]
	public class DevMenuWindow : WindowWhitCloseButton<BaseWindowArgs>
	{
		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600596F RID: 22895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700123F")]
		public override string WindowId
		{
			[Token(Token = "0x600596F")]
			[Address(RVA = "0xA69B", Offset = "0xA69B", VA = "0xA69B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06005970 RID: 22896 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x17001240")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6005970")]
			[Address(RVA = "0xA69C", Offset = "0xA69C", VA = "0xA69C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005971")]
		[Address(RVA = "0xA69D", Offset = "0xA69D", VA = "0xA69D", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005972")]
		[Address(RVA = "0xA69E", Offset = "0xA69E", VA = "0xA69E")]
		public void OnCopyDeviceId()
		{
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005973")]
		[Address(RVA = "0xA69F", Offset = "0xA69F", VA = "0xA69F")]
		private void TryRunViewModeClanCombat()
		{
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005974")]
		[Address(RVA = "0xA6A0", Offset = "0xA6A0", VA = "0xA6A0")]
		private void RestartGameWhitGoogleBilling()
		{
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005975")]
		[Address(RVA = "0xA6A1", Offset = "0xA6A1", VA = "0xA6A1")]
		private void RestarGameWhitHvBilling()
		{
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005976")]
		[Address(RVA = "0xA6A2", Offset = "0xA6A2", VA = "0xA6A2")]
		private void EmulateDisconnectCode()
		{
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005977")]
		[Address(RVA = "0xA6A3", Offset = "0xA6A3", VA = "0xA6A3")]
		private void EncreaseUserResources()
		{
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005978")]
		[Address(RVA = "0xA6A4", Offset = "0xA6A4", VA = "0xA6A4")]
		private void EncreaseUserLevel()
		{
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005979")]
		[Address(RVA = "0xA6A5", Offset = "0xA6A5", VA = "0xA6A5")]
		public DevMenuWindow()
		{
		}

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DevMenuWindow";

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _loadSceneButton;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _infoText;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _restarGameDefault;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _stopCurrentCombatButton;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle _guideDevEditTool;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextToolTip _textTool;

		// Token: 0x0400303F RID: 12351
		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextToolTip _textTool2;

		// Token: 0x04003040 RID: 12352
		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextToolTip _textToolBottomRight;

		// Token: 0x04003041 RID: 12353
		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextToolTip _textToolTopLeft;

		// Token: 0x04003042 RID: 12354
		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _deviceId;

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpriteAtlas _cloudSpriteAtlas;

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x64")]
		private DeviceIDProvider _deviceIDProvider;
	}
}
