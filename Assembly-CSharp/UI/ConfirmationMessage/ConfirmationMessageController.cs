using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ConfirmationMessage
{
	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	public class ConfirmationMessageController : MonoBehaviour
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F3")]
		public float DefaultDuration
		{
			[Token(Token = "0x6000E77")]
			[Address(RVA = "0x60F8", Offset = "0x60F8", VA = "0x60F8")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x60F9", Offset = "0x60F9", VA = "0x60F9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x60FA", Offset = "0x60FA", VA = "0x60FA")]
		public void Show(string message)
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x60FB", Offset = "0x60FB", VA = "0x60FB")]
		public void Show(string message, float duration)
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x60FC", Offset = "0x60FC", VA = "0x60FC")]
		public void Hide()
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x60FD", Offset = "0x60FD", VA = "0x60FD")]
		private void HandleQueue()
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x60FE", Offset = "0x60FE", VA = "0x60FE")]
		private void TempOnComplete()
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x60FF", Offset = "0x60FF", VA = "0x60FF")]
		public ConfirmationMessageController()
		{
		}

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ConfirmationMessageRenderer _confirmationMessageRenderer;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _block;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x1C")]
		private Queue<ConfirmationMessageController.ConfirmationMessageData> _queue;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x20")]
		private ConfirmationMessageController.ConfirmationMessageData _currentMessage;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x24")]
		private Tween _delayedCall;

		// Token: 0x02000257 RID: 599
		[Token(Token = "0x2000257")]
		private class ConfirmationMessageData
		{
			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001F4")]
			public string Message
			{
				[Token(Token = "0x6000E7F")]
				[Address(RVA = "0x6100", Offset = "0x6100", VA = "0x6100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001F5 RID: 501
			// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00004260 File Offset: 0x00002460
			[Token(Token = "0x170001F5")]
			public float Duration
			{
				[Token(Token = "0x6000E80")]
				[Address(RVA = "0x6101", Offset = "0x6101", VA = "0x6101")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06000E81 RID: 3713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E81")]
			[Address(RVA = "0x6102", Offset = "0x6102", VA = "0x6102")]
			public ConfirmationMessageData(string message, float duration)
			{
			}
		}
	}
}
