using System;
using System.Runtime.InteropServices;
using Gameplay.Fresco.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007EA RID: 2026
	[Token(Token = "0x20007EA")]
	public class FrescoBalanceView : MonoBehaviour
	{
		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700093A")]
		private CanvasGroup CanvasGroup
		{
			[Token(Token = "0x6002F8E")]
			[Address(RVA = "0x7FF4", Offset = "0x7FF4", VA = "0x7FF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x7FF5", Offset = "0x7FF5", VA = "0x7FF5")]
		private void Awake()
		{
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x7FF6", Offset = "0x7FF6", VA = "0x7FF6")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x7FF7", Offset = "0x7FF7", VA = "0x7FF7")]
		private void Start()
		{
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x7FF8", Offset = "0x7FF8", VA = "0x7FF8")]
		private void UniversalFragmentsCountChanged(uint balance)
		{
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x7FF9", Offset = "0x7FF9", VA = "0x7FF9")]
		private void DisplayCurrentBalance([Optional] uint? balance)
		{
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F94")]
		[Address(RVA = "0x7FFA", Offset = "0x7FFA", VA = "0x7FFA")]
		public FrescoBalanceView()
		{
		}

		// Token: 0x040019E0 RID: 6624
		[Token(Token = "0x40019E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x040019E1 RID: 6625
		[Token(Token = "0x40019E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x040019E2 RID: 6626
		[Token(Token = "0x40019E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _installButton;

		// Token: 0x040019E3 RID: 6627
		[Token(Token = "0x40019E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CanvasGroup _canvasGroup;

		// Token: 0x040019E4 RID: 6628
		[Token(Token = "0x40019E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FrescoModel _model;

		// Token: 0x040019E5 RID: 6629
		[Token(Token = "0x40019E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly TweenContainer _tweenContainer;
	}
}
