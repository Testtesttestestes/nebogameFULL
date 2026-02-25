using System;
using System.Runtime.InteropServices;
using AssetContent;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.ThemeDuelState.View.Balance
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	public class ThemeDuelBalanceView : MonoBehaviour
	{
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053B")]
		private CanvasGroup CanvasGroup
		{
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x6EC1", Offset = "0x6EC1", VA = "0x6EC1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x6EC2", Offset = "0x6EC2", VA = "0x6EC2")]
		private void Awake()
		{
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x6EC3", Offset = "0x6EC3", VA = "0x6EC3")]
		private void Start()
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x6EC4", Offset = "0x6EC4", VA = "0x6EC4")]
		private void BalanceChanged(long balance)
		{
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x6EC5", Offset = "0x6EC5", VA = "0x6EC5")]
		private void DisplayCurrentBalance([Optional] long? balance)
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x6EC6", Offset = "0x6EC6", VA = "0x6EC6")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x6EC7", Offset = "0x6EC7", VA = "0x6EC7")]
		private void UpdateView()
		{
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x6EC8", Offset = "0x6EC8", VA = "0x6EC8")]
		public ThemeDuelBalanceView()
		{
		}

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CanvasGroup _canvasGroup;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ThemeDuelStateModel _model;

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly TweenContainer _tweenContainer;
	}
}
