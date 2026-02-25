using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Toggle
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	[AddComponentMenu("Heavens/UI/Toggle")]
	public class Toggle : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IToggleControl
	{
		// Token: 0x140000D8 RID: 216
		// (add) Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D8")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x5D98", Offset = "0x5D98", VA = "0x5D98", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x5D99", Offset = "0x5D99", VA = "0x5D99", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x5D9A", Offset = "0x5D9A", VA = "0x5D9A")]
		private float GetEnabledAppearAlpha()
		{
			return 0f;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x5D9B", Offset = "0x5D9B", VA = "0x5D9B")]
		private float GetDuration(bool isImmediate)
		{
			return 0f;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x5D9C", Offset = "0x5D9C", VA = "0x5D9C", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x5D9D", Offset = "0x5D9D", VA = "0x5D9D")]
		private void SetIsEnabled(bool value, bool isImmediate)
		{
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x5D9E", Offset = "0x5D9E", VA = "0x5D9E", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x5D9F", Offset = "0x5D9F", VA = "0x5D9F", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x5DA0", Offset = "0x5DA0", VA = "0x5DA0")]
		private void Awake()
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x5DA1", Offset = "0x5DA1", VA = "0x5DA1")]
		private void OnValidate()
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x5DA2", Offset = "0x5DA2", VA = "0x5DA2")]
		public Toggle()
		{
		}

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _isEnabled;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _appearEnabled;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _pointer;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _pointerDisabled;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _textEnabled;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RectTransform _textDisabled;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _anchorEnabled;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RectTransform _anchorDisabled;
	}
}
