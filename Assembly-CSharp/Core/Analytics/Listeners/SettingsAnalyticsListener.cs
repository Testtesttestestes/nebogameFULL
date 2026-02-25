using System;
using Core.Data.User;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DD RID: 4829
	[Token(Token = "0x20012DD")]
	public class SettingsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x060072E3 RID: 29411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001741")]
		protected override string Theme
		{
			[Token(Token = "0x60072E3")]
			[Address(RVA = "0xBCEC", Offset = "0xBCEC", VA = "0xBCEC", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E4")]
		[Address(RVA = "0xBCED", Offset = "0xBCED", VA = "0xBCED", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E5")]
		[Address(RVA = "0xBCEE", Offset = "0xBCEE", VA = "0xBCEE", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E6")]
		[Address(RVA = "0xBCEF", Offset = "0xBCEF", VA = "0xBCEF")]
		private void SettingsChangedEvent(SettingsScope.SettingsEventArgs e)
		{
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E7")]
		[Address(RVA = "0xBCF0", Offset = "0xBCF0", VA = "0xBCF0")]
		private void SetSettings(UserSettings userSettings)
		{
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E8")]
		[Address(RVA = "0xBCF1", Offset = "0xBCF1", VA = "0xBCF1")]
		private void SettingsInitializedEvent(SettingsScope.SettingsEventArgs e)
		{
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E9")]
		[Address(RVA = "0xBCF2", Offset = "0xBCF2", VA = "0xBCF2")]
		public SettingsAnalyticsListener()
		{
		}

		// Token: 0x04003C2B RID: 15403
		[Token(Token = "0x4003C2B")]
		private const string SETTINGS_CHANGED = "changed";
	}
}
