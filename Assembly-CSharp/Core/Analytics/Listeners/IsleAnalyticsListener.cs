using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D5 RID: 4821
	[Token(Token = "0x20012D5")]
	public class IsleAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x0600729C RID: 29340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001739")]
		protected override string Theme
		{
			[Token(Token = "0x600729C")]
			[Address(RVA = "0xBCA5", Offset = "0xBCA5", VA = "0xBCA5", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729D")]
		[Address(RVA = "0xBCA6", Offset = "0xBCA6", VA = "0xBCA6", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729E")]
		[Address(RVA = "0xBCA7", Offset = "0xBCA7", VA = "0xBCA7", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729F")]
		[Address(RVA = "0xBCA8", Offset = "0xBCA8", VA = "0xBCA8")]
		private void AccelerateBuildEvent(IsleScope.BuildingEventArgs e)
		{
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A0")]
		[Address(RVA = "0xBCA9", Offset = "0xBCA9", VA = "0xBCA9")]
		private void CancelBuildEvent(IsleScope.BuildingEventArgs e)
		{
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A1")]
		[Address(RVA = "0xBCAA", Offset = "0xBCAA", VA = "0xBCAA")]
		private void StartBuildEvent(IsleScope.BuildingEventArgs e)
		{
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A2")]
		[Address(RVA = "0xBCAB", Offset = "0xBCAB", VA = "0xBCAB")]
		private void AppendBuildingProperties(Dictionary<string, object> properties, IsleScope.BuildingEventArgs e)
		{
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A3")]
		[Address(RVA = "0xBCAC", Offset = "0xBCAC", VA = "0xBCAC")]
		private void IsleAnimationButtonClickEvent(IsleScope.IsleAnimationButtonClickEventArgs e)
		{
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A4")]
		[Address(RVA = "0xBCAD", Offset = "0xBCAD", VA = "0xBCAD")]
		private void IsleBonusCollectedEvent(IsleScope.IsleBonusEventArgs e)
		{
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A5")]
		[Address(RVA = "0xBCAE", Offset = "0xBCAE", VA = "0xBCAE")]
		public IsleAnalyticsListener()
		{
		}

		// Token: 0x04003C0A RID: 15370
		[Token(Token = "0x4003C0A")]
		private const string ISLE_BONUS_COLLECTED = "isle_bonus_collected";

		// Token: 0x04003C0B RID: 15371
		[Token(Token = "0x4003C0B")]
		private const string ISLE_ANIMATION_BUTTON_CLICK = "isle_animation_button_click";

		// Token: 0x04003C0C RID: 15372
		[Token(Token = "0x4003C0C")]
		private const string START_BUILD = "start_build";

		// Token: 0x04003C0D RID: 15373
		[Token(Token = "0x4003C0D")]
		private const string CANCEL_BUILD = "cancel_build";

		// Token: 0x04003C0E RID: 15374
		[Token(Token = "0x4003C0E")]
		private const string ACCELERATE_BUILD = "accelerate_build";

		// Token: 0x04003C0F RID: 15375
		[Token(Token = "0x4003C0F")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<ulong> _loggedCollectBonusOwners;
	}
}
