using System;
using Gameplay.Isles.Clan.View;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012F4 RID: 4852
	[Token(Token = "0x20012F4")]
	public class ClanIsleWorldObject : BaseIsleWorldObject
	{
		// Token: 0x06007382 RID: 29570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007382")]
		[Address(RVA = "0xBD6E", Offset = "0xBD6E", VA = "0xBD6E", Slot = "12")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007383")]
		[Address(RVA = "0xBD6F", Offset = "0xBD6F", VA = "0xBD6F", Slot = "13")]
		public override void UpdateOrder()
		{
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007384")]
		[Address(RVA = "0xBD70", Offset = "0xBD70", VA = "0xBD70", Slot = "14")]
		public override void Reset()
		{
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007385")]
		[Address(RVA = "0xBD71", Offset = "0xBD71", VA = "0xBD71")]
		public ClanIsleWorldObject()
		{
		}

		// Token: 0x04003C72 RID: 15474
		[Token(Token = "0x4003C72")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ClanIsleView _isleView;

		// Token: 0x04003C73 RID: 15475
		[Token(Token = "0x4003C73")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClanIsleGolemView _golemView;
	}
}
