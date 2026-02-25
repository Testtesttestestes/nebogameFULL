using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Misc
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x20001D5")]
	public class AdditionalButtonsView : MonoBehaviour
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x5F56", Offset = "0x5F56", VA = "0x5F56")]
		private void Awake()
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x5F57", Offset = "0x5F57", VA = "0x5F57")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x5F58", Offset = "0x5F58", VA = "0x5F58")]
		private void CharacterButtonClickedEventHandler()
		{
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x5F59", Offset = "0x5F59", VA = "0x5F59")]
		private void ChestButtonClickedEventHandler()
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x5F5A", Offset = "0x5F5A", VA = "0x5F5A")]
		public AdditionalButtonsView()
		{
		}

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _chestButton;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _userInfoButton;
	}
}
