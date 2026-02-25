using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FA RID: 1018
	[Token(Token = "0x20003FA")]
	public class NickVariantItemRow : MonoBehaviour
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000427")]
		public TextMeshProUGUI TextField
		{
			[Token(Token = "0x60017DF")]
			[Address(RVA = "0x699A", Offset = "0x699A", VA = "0x699A")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000115 RID: 277
		// (add) Token: 0x060017E0 RID: 6112 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000115")]
		public event Action<string> OnConfirmSelect
		{
			[Token(Token = "0x60017E0")]
			[Address(RVA = "0x699B", Offset = "0x699B", VA = "0x699B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60017E1")]
			[Address(RVA = "0x699C", Offset = "0x699C", VA = "0x699C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x699D", Offset = "0x699D", VA = "0x699D")]
		private void Awake()
		{
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x699E", Offset = "0x699E", VA = "0x699E")]
		private void HandleClick()
		{
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x699F", Offset = "0x699F", VA = "0x699F")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x69A0", Offset = "0x69A0", VA = "0x69A0")]
		public NickVariantItemRow()
		{
		}

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _textField;
	}
}
