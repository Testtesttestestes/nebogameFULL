using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C35 RID: 3125
	[Token(Token = "0x2000C35")]
	public class BankGalleryView : MonoBehaviour
	{
		// Token: 0x06004C2F RID: 19503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004C2F")]
		[Address(RVA = "0x9A73", Offset = "0x9A73", VA = "0x9A73")]
		private IEnumerator ShowNextElementDemo()
		{
			return null;
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x1EFC", Offset = "0x1EFC", VA = "0x1EFC")]
		public void AddElement(GameObject element)
		{
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x9A74", Offset = "0x9A74", VA = "0x9A74")]
		private void RestartDemo()
		{
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x9A75", Offset = "0x9A75", VA = "0x9A75")]
		private void ButtonOnSelectEvent(PointerEventData pointerEventData)
		{
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x9A76", Offset = "0x9A76", VA = "0x9A76")]
		public void SelectByIndex(int index)
		{
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x9A77", Offset = "0x9A77", VA = "0x9A77")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x9A78", Offset = "0x9A78", VA = "0x9A78")]
		public BankGalleryView()
		{
		}

		// Token: 0x0400297C RID: 10620
		[Token(Token = "0x400297C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400297D RID: 10621
		[Token(Token = "0x400297D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0400297E RID: 10622
		[Token(Token = "0x400297E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _selectedButtonImage;

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _buttonsContainer;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MonoPointerClickHandler _bankGalleryButtonPrefab;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _demoModeDelay;

		// Token: 0x04002982 RID: 10626
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform _buttonsContainerRectTransform;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x2C")]
		private List<MonoPointerClickHandler> _buttons;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x30")]
		private int _currentSelectedIndex;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x34")]
		private Coroutine _demoCoroutine;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x38")]
		private TweenContainer _tweenContainer;
	}
}
