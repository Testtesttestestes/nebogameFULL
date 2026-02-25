using System;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Accounts.View.Accounts
{
	// Token: 0x02000DD8 RID: 3544
	[Token(Token = "0x2000DD8")]
	public class ManufactureAccountView : DefaultAccountView
	{
		// Token: 0x06005666 RID: 22118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005666")]
		[Address(RVA = "0xA3F3", Offset = "0xA3F3", VA = "0xA3F3")]
		public ManufactureViewInAccountView GetManufactureView()
		{
			return null;
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005667")]
		[Address(RVA = "0xA3F4", Offset = "0xA3F4", VA = "0xA3F4", Slot = "8")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005668")]
		[Address(RVA = "0xA3F5", Offset = "0xA3F5", VA = "0xA3F5")]
		public ManufactureAccountView()
		{
		}

		// Token: 0x04002EE1 RID: 12001
		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ManufactureViewInAccountView _manufactureViewPrefab;

		// Token: 0x04002EE2 RID: 12002
		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _manufactureViewContainer;

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x54")]
		private ManufactureViewInAccountView _manufactureView;
	}
}
