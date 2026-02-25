using System;
using Gameplay.Isles.User.View;
using Gameplay.Isles.User.View.Monster;
using Gameplay.Portals.View;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001309 RID: 4873
	[Token(Token = "0x2001309")]
	public class UserIsleWorldObject : BaseIsleWorldObject
	{
		// Token: 0x060073DF RID: 29663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DF")]
		[Address(RVA = "0xBDC2", Offset = "0xBDC2", VA = "0xBDC2", Slot = "12")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E0")]
		[Address(RVA = "0xBDC3", Offset = "0xBDC3", VA = "0xBDC3", Slot = "13")]
		public override void UpdateOrder()
		{
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E1")]
		[Address(RVA = "0xBDC4", Offset = "0xBDC4", VA = "0xBDC4", Slot = "14")]
		public override void Reset()
		{
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E2")]
		[Address(RVA = "0xBDC5", Offset = "0xBDC5", VA = "0xBDC5")]
		public UserIsleWorldObject()
		{
		}

		// Token: 0x04003CB1 RID: 15537
		[Token(Token = "0x4003CB1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private UserIsleView _isleView;

		// Token: 0x04003CB2 RID: 15538
		[Token(Token = "0x4003CB2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PortalsEntryPointView _portalsEntryPointView;

		// Token: 0x04003CB3 RID: 15539
		[Token(Token = "0x4003CB3")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private IsleMonsterView _monsterView;

		// Token: 0x04003CB4 RID: 15540
		[Token(Token = "0x4003CB4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BackClanIsleView _backClanIsleView;

		// Token: 0x04003CB5 RID: 15541
		[Token(Token = "0x4003CB5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ColossusOnUserIsleView _colossusView;
	}
}
