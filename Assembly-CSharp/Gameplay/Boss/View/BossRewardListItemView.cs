using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B50 RID: 2896
	[Token(Token = "0x2000B50")]
	public class BossRewardListItemView : MonoBehaviour
	{
		// Token: 0x140001AF RID: 431
		// (add) Token: 0x06004607 RID: 17927 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004608 RID: 17928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AF")]
		public event Action<BossRewardListItemView> ClickEvent
		{
			[Token(Token = "0x6004607")]
			[Address(RVA = "0x94A0", Offset = "0x94A0", VA = "0x94A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004608")]
			[Address(RVA = "0x94A1", Offset = "0x94A1", VA = "0x94A1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600460A RID: 17930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC9")]
		public BossInfo.BossRewardRangeData Data
		{
			[Token(Token = "0x6004609")]
			[Address(RVA = "0x94A2", Offset = "0x94A2", VA = "0x94A2")]
			get
			{
				return null;
			}
			[Token(Token = "0x600460A")]
			[Address(RVA = "0x94A3", Offset = "0x94A3", VA = "0x94A3")]
			set
			{
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x0600460B RID: 17931 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		// (set) Token: 0x0600460C RID: 17932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DCA")]
		public bool Selected
		{
			[Token(Token = "0x600460B")]
			[Address(RVA = "0x94A4", Offset = "0x94A4", VA = "0x94A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600460C")]
			[Address(RVA = "0x94A5", Offset = "0x94A5", VA = "0x94A5")]
			set
			{
			}
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460D")]
		[Address(RVA = "0x94A6", Offset = "0x94A6", VA = "0x94A6")]
		private void Awake()
		{
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460E")]
		[Address(RVA = "0x94A7", Offset = "0x94A7", VA = "0x94A7")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460F")]
		[Address(RVA = "0x94A8", Offset = "0x94A8", VA = "0x94A8")]
		private void ClickHandlerOnOnClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004610")]
		[Address(RVA = "0x94A9", Offset = "0x94A9", VA = "0x94A9")]
		public BossRewardListItemView()
		{
		}

		// Token: 0x04002649 RID: 9801
		[Token(Token = "0x4002649")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x0400264A RID: 9802
		[Token(Token = "0x400264A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x0400264B RID: 9803
		[Token(Token = "0x400264B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x0400264C RID: 9804
		[Token(Token = "0x400264C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _customBg;

		// Token: 0x0400264D RID: 9805
		[Token(Token = "0x400264D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _index0Sprite;

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _index1Sprite;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _index2Sprite;

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _defaultSprite;

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[FieldOffset(Offset = "0x34")]
		private BossInfo.BossRewardRangeData _data;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[FieldOffset(Offset = "0x38")]
		private bool _selected;
	}
}
