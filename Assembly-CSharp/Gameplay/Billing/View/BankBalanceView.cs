using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Billing.View
{
	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000BDE")]
	public class BankBalanceView : MonoBehaviour
	{
		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F0D")]
		protected CanvasGroup CanvasGroup
		{
			[Token(Token = "0x6004A92")]
			[Address(RVA = "0x98F4", Offset = "0x98F4", VA = "0x98F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A93")]
		[Address(RVA = "0x98F5", Offset = "0x98F5", VA = "0x98F5")]
		private void Awake()
		{
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A94")]
		[Address(RVA = "0x98F6", Offset = "0x98F6", VA = "0x98F6")]
		private void Start()
		{
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A95")]
		[Address(RVA = "0x98F7", Offset = "0x98F7", VA = "0x98F7")]
		private void BalanceChanged()
		{
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A96")]
		[Address(RVA = "0x98F8", Offset = "0x98F8", VA = "0x98F8")]
		private void DisplayCurrentBalance()
		{
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A97")]
		[Address(RVA = "0x98F9", Offset = "0x98F9", VA = "0x98F9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A98")]
		[Address(RVA = "0x98FA", Offset = "0x98FA", VA = "0x98FA")]
		public BankBalanceView()
		{
		}

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		[FieldOffset(Offset = "0x1C")]
		private TweenContainer _tweenContainer;
	}
}
