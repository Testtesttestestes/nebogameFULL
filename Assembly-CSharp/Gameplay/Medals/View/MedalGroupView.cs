using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x20005F5")]
	public class MedalGroupView : MonoBehaviour
	{
		// Token: 0x1400014C RID: 332
		// (add) Token: 0x060024EE RID: 9454 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060024EF RID: 9455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014C")]
		private event Action<MedalView> ClickCallback
		{
			[Token(Token = "0x60024EE")]
			[Address(RVA = "0x7639", Offset = "0x7639", VA = "0x7639")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60024EF")]
			[Address(RVA = "0x763A", Offset = "0x763A", VA = "0x763A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E1")]
		public MedalData MedalData
		{
			[Token(Token = "0x60024F0")]
			[Address(RVA = "0x763B", Offset = "0x763B", VA = "0x763B")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024F1")]
			[Address(RVA = "0x763C", Offset = "0x763C", VA = "0x763C")]
			set
			{
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E2")]
		public bool SaleEnabled
		{
			[Token(Token = "0x60024F2")]
			[Address(RVA = "0x763D", Offset = "0x763D", VA = "0x763D")]
			set
			{
			}
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x763E", Offset = "0x763E", VA = "0x763E")]
		private void Awake()
		{
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x763F", Offset = "0x763F", VA = "0x763F")]
		private void OnDestroy()
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x7640", Offset = "0x7640", VA = "0x7640")]
		private void MedalViewOnClickEvent(MedalView medalView)
		{
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x7641", Offset = "0x7641", VA = "0x7641")]
		public void SetUsers(UserData user, UserData loggedUser)
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x7642", Offset = "0x7642", VA = "0x7642")]
		public void SetCallback(Action<MedalView> clickCallback)
		{
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x7643", Offset = "0x7643", VA = "0x7643")]
		public MedalGroupView()
		{
		}

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected MedalView _medalView;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Price _price;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x18")]
		private UserData _userData;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x1C")]
		private UserData _loggedUserData;

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x24")]
		private MedalData _medalData;
	}
}
