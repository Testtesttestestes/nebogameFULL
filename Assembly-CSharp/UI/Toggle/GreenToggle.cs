using System;
using System.Runtime.CompilerServices;
using I2.Loc;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace UI.Toggle
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public class GreenToggle : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IToggleControl
	{
		// Token: 0x140000D6 RID: 214
		// (add) Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D6")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x5D8C", Offset = "0x5D8C", VA = "0x5D8C", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x5D8D", Offset = "0x5D8D", VA = "0x5D8D", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00003870 File Offset: 0x00001A70
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x5D8E", Offset = "0x5D8E", VA = "0x5D8E", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x5D8F", Offset = "0x5D8F", VA = "0x5D8F", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x5D90", Offset = "0x5D90", VA = "0x5D90")]
		private void SetIsEnableInternal(bool value, bool immediate)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x5D91", Offset = "0x5D91", VA = "0x5D91")]
		private Vector2 GetTogglePosition()
		{
			return default(Vector2);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x5D92", Offset = "0x5D92", VA = "0x5D92")]
		private HorizontalAlignmentOptions GetLabelAlign()
		{
			return (HorizontalAlignmentOptions)0;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x5D93", Offset = "0x5D93", VA = "0x5D93")]
		private float GetGreenBgAlpha()
		{
			return 0f;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x5D94", Offset = "0x5D94", VA = "0x5D94")]
		private void Awake()
		{
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x5D95", Offset = "0x5D95", VA = "0x5D95")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x5D96", Offset = "0x5D96", VA = "0x5D96", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x5D97", Offset = "0x5D97", VA = "0x5D97")]
		public GreenToggle()
		{
		}

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _toggleView;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _greenBg;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _togglePadding;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LocalizedString _enabledText;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LocalizedString _disabledText;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransform;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x48")]
		private bool _isEnabled;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x4C")]
		private TweenContainer _tweenContainer;
	}
}
