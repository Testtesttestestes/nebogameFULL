using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent.Loaders;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using TMPro;
using UI.Tweens;
using UnityEngine;
using UnityEngine.Pool;

namespace Gameplay.Competition.View.GetRatingRewardWidget
{
	// Token: 0x020008E9 RID: 2281
	[Token(Token = "0x20008E9")]
	public class CompetitionGetRatingView : MonoBehaviour
	{
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AA8")]
		public GameImageLoader Icon
		{
			[Token(Token = "0x60035BE")]
			[Address(RVA = "0x85CC", Offset = "0x85CC", VA = "0x85CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x85CD", Offset = "0x85CD", VA = "0x85CD")]
		private CompetitionGetRatingView()
		{
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x17000AA9")]
		public float Value
		{
			[Token(Token = "0x60035C0")]
			[Address(RVA = "0x85CE", Offset = "0x85CE", VA = "0x85CE")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x85CF", Offset = "0x85CF", VA = "0x85CF")]
		private void Awake()
		{
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x85D0", Offset = "0x85D0", VA = "0x85D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x85D1", Offset = "0x85D1", VA = "0x85D1")]
		private IEnumerator Show()
		{
			return null;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x85D2", Offset = "0x85D2", VA = "0x85D2")]
		private IEnumerator Hide()
		{
			return null;
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x85D3", Offset = "0x85D3", VA = "0x85D3")]
		private IEnumerator Handle()
		{
			return null;
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x85D4", Offset = "0x85D4", VA = "0x85D4")]
		private IEnumerator MoveToTarget(TweeningValue item, TweeningValue target, LinkedList<TweeningValue> visibleItems, float duration, float delay, bool skipAwaitCounter)
		{
			return null;
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x85D5", Offset = "0x85D5", VA = "0x85D5")]
		private IEnumerator Run()
		{
			return null;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x44A1", Offset = "0x44A1", VA = "0x44A1")]
		public void Add(params float[] values)
		{
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x85D6", Offset = "0x85D6", VA = "0x85D6")]
		public void SetValue(float value)
		{
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x85D7", Offset = "0x85D7", VA = "0x85D7")]
		private void DebugAddValue(uint count = 1U)
		{
		}

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _valueTextField;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x4001D66")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TweeningValue _target;

		// Token: 0x04001D67 RID: 7527
		[Token(Token = "0x4001D67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TweeningValue _valuePrefab;

		// Token: 0x04001D68 RID: 7528
		[Token(Token = "0x4001D68")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _summatorAnchor;

		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _queueValueAnchor;

		// Token: 0x04001D6A RID: 7530
		[Token(Token = "0x4001D6A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04001D6B RID: 7531
		[Token(Token = "0x4001D6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _valuesContainer;

		// Token: 0x04001D6C RID: 7532
		[Token(Token = "0x4001D6C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameImageLoader _icon;

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _showHideDuration;

		// Token: 0x04001D6E RID: 7534
		[Token(Token = "0x4001D6E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _moveItemsDuration;

		// Token: 0x04001D6F RID: 7535
		[Token(Token = "0x4001D6F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _moveSummatorDuration;

		// Token: 0x04001D70 RID: 7536
		[Token(Token = "0x4001D70")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _moveSummatorDelay;

		// Token: 0x04001D71 RID: 7537
		[Token(Token = "0x4001D71")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _runRoutine;

		// Token: 0x04001D72 RID: 7538
		[Token(Token = "0x4001D72")]
		[FieldOffset(Offset = "0x44")]
		private IViewMediator _mediator;

		// Token: 0x04001D73 RID: 7539
		[Token(Token = "0x4001D73")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 _startAnchoredPosition;

		// Token: 0x04001D74 RID: 7540
		[Token(Token = "0x4001D74")]
		[FieldOffset(Offset = "0x50")]
		private readonly ObjectPool<TweeningValue> _valuesPool;

		// Token: 0x04001D75 RID: 7541
		[Token(Token = "0x4001D75")]
		[FieldOffset(Offset = "0x54")]
		private readonly Queue<float> _queue;
	}
}
