using System;
using System.Runtime.InteropServices;
using AssetContent;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations;
using UnityEngine;
using Utils;

namespace Gameplay.Portals.View.Balance
{
	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	public class PortalsBalanceView : MonoBehaviour
	{
		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006A0")]
		private CanvasGroup CanvasGroup
		{
			[Token(Token = "0x600238A")]
			[Address(RVA = "0x74DC", Offset = "0x74DC", VA = "0x74DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x74DD", Offset = "0x74DD", VA = "0x74DD")]
		private void Awake()
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x74DE", Offset = "0x74DE", VA = "0x74DE")]
		private void Start()
		{
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x74DF", Offset = "0x74DF", VA = "0x74DF")]
		private void UserInfoChanged()
		{
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x74E0", Offset = "0x74E0", VA = "0x74E0")]
		private void DisplayCurrentBalance([Optional] ulong? balance)
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x74E1", Offset = "0x74E1", VA = "0x74E1")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x74E2", Offset = "0x74E2", VA = "0x74E2")]
		private void UpdateView()
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x74E3", Offset = "0x74E3", VA = "0x74E3")]
		public PortalsBalanceView()
		{
		}

		// Token: 0x0400139D RID: 5021
		[Token(Token = "0x400139D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x0400139E RID: 5022
		[Token(Token = "0x400139E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x0400139F RID: 5023
		[Token(Token = "0x400139F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x040013A0 RID: 5024
		[Token(Token = "0x40013A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextToolTip _currencyToolTip;

		// Token: 0x040013A1 RID: 5025
		[Token(Token = "0x40013A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup _canvasGroup;

		// Token: 0x040013A2 RID: 5026
		[Token(Token = "0x40013A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private PortalsModel _model;

		// Token: 0x040013A3 RID: 5027
		[Token(Token = "0x40013A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly TweenContainer _tweenContainer;
	}
}
