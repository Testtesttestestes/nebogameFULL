using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace UI.Toast
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public class ToastView : MonoBehaviour
	{
		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D9")]
		public event Action<ToastView> HideCompleteEvent
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x5DC5", Offset = "0x5DC5", VA = "0x5DC5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x5DC6", Offset = "0x5DC6", VA = "0x5DC6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		public int AddedAtIndex
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x5DC7", Offset = "0x5DC7", VA = "0x5DC7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x5DC8", Offset = "0x5DC8", VA = "0x5DC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x5DC9", Offset = "0x5DC9", VA = "0x5DC9")]
		public void Show(ToastController.ToastData toastData, int addedAtIndex)
		{
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x5DCA", Offset = "0x5DCA", VA = "0x5DCA")]
		public void Hide()
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x5DCB", Offset = "0x5DCB", VA = "0x5DCB")]
		public void Reset()
		{
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x5DCC", Offset = "0x5DCC", VA = "0x5DCC")]
		public ToastView()
		{
		}

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _rect;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _message;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x28")]
		private ToastController.ToastData _toastData;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x2C")]
		private TweenContainer _tweenContainer;
	}
}
